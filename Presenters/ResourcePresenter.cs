using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LitRevResourceMVP.Models;
using LitRevResourceMVP.Views;


namespace LitRevResourceMVP.Presenters
{
    public class ResourcePresenter
    {
        private IResourceView view;
        private IResourceRepository repository;
        private BindingSource resourceBindingSource;
        private BindingSource categoryBindingSource;
        private BindingSource assignBindingSource;
        private IEnumerable<ResourceModel> resourceList;
        private IEnumerable<string> categoryList;
        private DataSet assignResDataSet;

        /// <summary>
        /// Setup events args to event handlers and assignment bindings source.
        /// </summary>
        /// <param name="view"></param>
        /// <param name="repository"></param>
        public ResourcePresenter(IResourceView view, IResourceRepository repository)
        {
            this.resourceBindingSource = new BindingSource();
            this.categoryBindingSource = new BindingSource();
            this.assignBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //used in tab1 main
            this.view.SearchEvent += SearchForResource;
            this.view.AddNewEvent += AddNewResource;
            this.view.DeleteEvent += DeleteResource;
            this.view.EditEvent += LoadResourceToEdit;
            this.view.ViewResourcesEvent += LoadAssignResources;
            ////used in tab2 add/edit resource
            this.view.CreateReferenceEvent += CreateReference;
            this.view.SaveEvent += SaveResource;
            this.view.CancelEvent += CancelAction;
            this.view.LinkLabelEvent += LinkLabelClick;
            this.view.SetAssignmentListBindingSource(assignBindingSource);
            this.view.SetResourceListBindingSource(resourceBindingSource);
            this.view.SetCategoryListBindingSource(categoryBindingSource);
            LoadAllAssignmentList();
            this.view.Show();
        }
        
        //used in second tab (tab1), display resource list and search request
        /// <summary>
        /// Binds assignment data table and repository method to display in datagridview for user selection. 
        /// </summary>
        private void LoadAllAssignmentList()
        {
            assignResDataSet = repository.GetDataSet();
            assignBindingSource.DataSource = assignResDataSet.Tables[0];
        }

        //used in SaveResource(), SearchForResource()
        /// <summary>
        /// Retrieves assignment id number from selected row to filter specific resources in the dataset. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadAssignResources(object sender, EventArgs e)
        {
            int idNum = int.Parse(view.AssignIdNum);
            assignResDataSet.Tables[1].DefaultView.RowFilter = "Assign_IdNum = " + idNum;
            resourceBindingSource.DataSource = assignResDataSet.Tables[1];
            LoadAllCategoriesList(idNum);
        }

        /// <summary>
        /// Binds list and repository method to retrieve distinct categories from database. 
        /// Displayed as readonly and for user information. 
        /// </summary>
        private void LoadAllCategoriesList(int idNum)
        {
            categoryList = repository.GetAllCategories(idNum);
            categoryBindingSource.DataSource = categoryList;
        }

        /// <summary>
        /// Binds resource list and repository method to search for a specific resource or grouped using category input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchForResource(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            int assignId = int.Parse(view.AssignIdNum);
            if (emptyValue == false)
            {
                resourceList = repository.GetByValue(this.view.SearchValue, assignId);
                resourceBindingSource.DataSource = resourceList;
            }
            else
                LoadAssignResources(sender,e);
        }

        /// <summary>
        /// Changes isEdit bool flag to false and thus call add method in saveResource().
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewResource(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        /// <summary>
        /// Combines edit and save function using bool isEdit status. Calls sql methods from repository to amend dataset and update database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveResource(object sender, EventArgs e)
        {
            
            var model = new ResourceModel();
            if (view.ResIdNum != "")
            {
                model.ID_Num = Convert.ToInt32(view.ResIdNum);
            }
            model.Web_Link = view.ResWebLink;
            model.Resource_Type = view.ResType;
            model.DOI_Num = view.ResDoiNum;
            model.Date_Accessed = view.ResDateAccessed;
            model.Category = view.ResCategory;
            model.Reference = view.ResReference;
            model.Main_Point = view.ResMainPoint;
            model.Main_Notes = view.ResNotes;
            model.Assign_IdNum = int.Parse(view.AssignIdNum);
            try
            {
                //takes validation requirements in ie resource models to validate input fields
                //throws exception with set message if incorrect input (cannot cast int32 to string)
                new Common.ModelDataValidation().Validate(model); //########### used for mvc not usually for mvp
                if (view.IsEdit)
                {
                    int id = int.Parse(view.ResIdNum);
                    repository.Edit(id, model, assignResDataSet);
                    view.Message = "Resource edited successfully";
                }
                else
                {
                    repository.Add(model, assignResDataSet);
                    view.Message = "Resource added successfully";
                }
                view.IsSuccessful = true;
                repository.UpdateDBFromDataTable(assignResDataSet);
                ClearAllTextFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Error = "+ ex.Message;
            }

        }

        /// <summary>
        /// Deletes row in assignment data table and updates sql database using sql method in repository.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteResource(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(view.ResIdNum);
                if (view.ResIdNum != "")
                {
                    repository.Delete(id, assignResDataSet);
                    view.IsSuccessful = true;
                    view.Message = "Resource deleted successfully";
                    repository.UpdateDBFromDataTable(assignResDataSet);
                }
                else
                {
                    view.Message = "Resource does not exist, delete failed";
                }
            }
            catch(Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Sorry, could not delete the resource due to an error"+ex.Message; 
            }
        }

        /// <summary>
        /// Sets isEdit bool flag to true to call edit method in saveResource(). Also calls method to display link label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadResourceToEdit(object sender, EventArgs e)
        {
            view.IsEdit = true;
            DisplayWebLink();
        }

        /// <summary>
        /// Display url string in web link textbox as an active web link when edit resource loads data 'LoadResourceToEdit'
        /// </summary>
        private void DisplayWebLink()
        {
            string createWebLink = "Creating web link";
            //remains in memory even if non active link clicked so must clear and reset to default
            view.ActiveWebLink.Links.Clear();
            try
            {
                if ((view.ResWebLink.StartsWith("https") || (view.ResWebLink.StartsWith("www"))) == true)
                {
                    view.ActiveWebLink.Text = view.ResWebLink;
                    LinkLabel.Link wblk = new LinkLabel.Link();
                    wblk.LinkData = view.ResWebLink;
                    view.ActiveWebLink.Links.Add(wblk);
                }
            }
            catch (Exception ex)
            {
                view.Message = "Error = " + ex.Message +"\n"+ createWebLink;
            }
        }

        /// <summary>
        /// Open webpage when weblink LklblWebLink_LinkClicked called
        /// Process.start doesn't work, github get around used, known issue in .netcore
        /// h ttps://github.com/dotnet/runtime/issues/21798.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private bool OpenBrowser(string url)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Process.Start(new ProcessStartInfo("cmd", $"/c start {url.Replace("&", "^&")}") { CreateNoWindow = true });
                return true;
            }
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Process.Start("xdg-open", url);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Web link click event to open a web page loaded from datatable when viewing a resource
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkLabelClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string openLink = "Opening web link";
            string target = e.Link.LinkData as string;
            if (target != null)
            {
                try
                {
                    e.Link.Visited = true;
                    OpenBrowser(target);
                }
                catch (Exception ex)
                {
                    view.Message = "Error opening link = " + ex.Message + "\nDetails-->\n" + openLink;
                }
            }
        }

        //used in second tab display/add/edit single resource
        /// <summary>
        /// Currently not used but intended to allow a user to manage references (CRUD) according to style.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateReference(object sender, EventArgs e)
        {
            MessageBox.Show("CreateReference not in operation yet");
        }


        /// <summary>
        /// Clear all textboxes of data. Used in saveResource(), cancelAction()
        /// </summary>
        private void ClearAllTextFields()
        {
            view.ResIdNum = "0";
            view.ResWebLink = "";
            view.ResType = "";
            view.ResDoiNum = "";
            view.ResCategory = "";
            view.ResReference = "";
            view.ResMainPoint = "";
            view.ResNotes = "";
        }

        /// <summary>
        /// Clear all textboxes if user changes their mind about editing/adding resource.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelAction(object sender, EventArgs e)
        {
            ClearAllTextFields();
        }








    }
}
