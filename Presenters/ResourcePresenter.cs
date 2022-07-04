using System;
using System.Collections.Generic;
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
        private BindingSource resourcedBindingSource;
        private BindingSource categoryBindingSource;
        private BindingSource assignmentBindingSource;
        private IEnumerable<ResourceModel> resourceList;
        private IEnumerable<string> categoryList;
        private IEnumerable<AssignmentModel> assignmentList;

        public ResourcePresenter(IResourceView view, IResourceRepository repository)
        {
            this.resourcedBindingSource = new BindingSource();
            this.categoryBindingSource = new BindingSource();
            this.assignmentBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            //used in tab1 main
            this.view.SearchEvent += SearchForResource;
            this.view.AddNewEvent += AddNewResource;
            this.view.DeleteEvent += DeleteResource;
            this.view.EditEvent += LoadResourceToEdit;
            

            ////used in tab2 add/edit resource
            this.view.CreateReferenceEvent += CreateReference;
            this.view.SaveEvent += SaveResource;
            this.view.CancelEvent += CancelAction;
            this.view.LinkLabelEvent += LinkLabelClick;

            this.view.SetResourceListBindingSource(resourcedBindingSource);
            this.view.SetCategoryListBindingSource(categoryBindingSource);
            this.view.SetAssignmentListBindingSource(assignmentBindingSource);

            LoadAllResourceList();
            LoadAllCategoriesList(); // ###### 
            LoadAllAssignmentList();
            this.view.Show();
        }

        
        //used in second tab (tab1), display resource list and search request
        private void LoadAllAssignmentList()
        {
            assignmentList = repository.GetAllAssignments();
            assignmentBindingSource.DataSource = assignmentList;

        }

        //used in SaveResource(), SearchForResource()
        private void LoadAllResourceList()
        {
            int IdNum = 0;
            resourceList = repository.GetAllResources(IdNum);
            resourcedBindingSource.DataSource = resourceList;
        }

        private void LoadAllCategoriesList()
        {
            categoryList = repository.GetAllCategories();
            categoryBindingSource.DataSource = categoryList;
        }
        private void SearchForResource(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                resourceList = repository.GetByValue(this.view.SearchValue);
                resourcedBindingSource.DataSource = resourceList;
            }
            else
                LoadAllResourceList();
        }

        private void AddNewResource(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void DeleteResource(object sender, EventArgs e)
        {
            try
            {
                var res = (ResourceModel)resourcedBindingSource.Current;
                repository.Delete(res.ID_Num);
                view.IsSuccessful = true;
                view.Message = "Resource deleted successfully";
                LoadAllResourceList();
            }
            catch(Exception)
            {
                view.IsSuccessful = false;
                view.Message = "Sorry, could not delete the resource due to an error"; 
            }
        }

        private void LoadResourceToEdit(object sender, EventArgs e)
        {
            var res = (ResourceModel)resourcedBindingSource.Current;
            view.ResIdNum = res.ID_Num.ToString();
            view.ResWebLink = res.Web_Link;
            view.ResType = res.Resource_Type;
            view.ResDoiNum = res.DOI_Num;
            view.ResDateAccessed = res.Date_Accessed.ToString();
            view.ResCategory = res.Category;
            view.ResReference = res.Reference;
            view.ResMainPoint = res.Main_Point;
            view.ResNotes = res.Main_Notes;
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
                MessageBox.Show("Error = " + ex.Message, createWebLink);
            }
        }

        /// <summary>
        /// Open webpage when weblink LklblWebLink_LinkClicked called
        /// Process.start doesn't work, github get around used, known issue in .netcore
        /// h ttps://github.com/dotnet/runtime/issues/21798 
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
        /// Web link click event to open a web page loaded from db
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
                    MessageBox.Show("Error opening link = " + ex.Message + "\nDetails-->\n" + ex, openLink);
                }
            }
        }

        //used in second tab display/add/edit single resource
        private void CreateReference(object sender, EventArgs e)
        {
            MessageBox.Show("CreateReference not in operation yet");
        }

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
            model.Date_Accessed = Convert.ToDateTime(view.ResDateAccessed);   
            model.Category = view.ResCategory;
            model.Reference = view.ResReference;
            model.Main_Point = view.ResMainPoint;
            model.Main_Notes = view.ResNotes;
            try
            {
                //takes validation requirements in ie resource models to validate input fields
                //throws exception with set message if incorrect input
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Resource edited successfully";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Resource added successfully";
                }
                view.IsSuccessful = true;
                LoadAllResourceList();
                ClearAllTextFields();
            }
            catch(Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        //used in saveResource(), cancelAction(), 
        private void ClearAllTextFields()
        {
            view.ResIdNum = "0";
            view.ResWebLink = "";
            view.ResType = "";
            view.ResDoiNum = "";
            view.ResDateAccessed = "";
            view.ResCategory = "";
            view.ResReference = "";
            view.ResMainPoint = "";
            view.ResNotes = "";

            //foreach (var c in view)
            //{
            //    if (c is TextBoxBase)
            //    {
            //        ((TextBoxBase)c).Text = String.Empty;
            //    }
            //}
            
        }

        private void CancelAction(object sender, EventArgs e)
        {
            ClearAllTextFields();
        }








    }
}
