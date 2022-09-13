using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LitRevResourceMVP.Models;
using LitRevResourceMVP.Views;

namespace LitRevResourceMVP.Presenters
{
    /// <summary>
    /// Assignment presenter to invoke view events and action repository business logic
    /// </summary>
    public class AssignmentPresenter
    {
        private readonly IAssignmentView view;
        private readonly IAssignmentRepository repository;
        private readonly BindingSource assignmentBindingSource;
        private readonly BindingSource moduleBindingSource;
        
        private IEnumerable<AssignmentModel> assignmentList;
        private IEnumerable<string> moduleNameList;

        /// <summary>
        /// Setup events args to event handlers and assignment bindings source.
        /// </summary>
        /// <param name="view"></param>
        /// <param name="repository"></param>
        public AssignmentPresenter(IAssignmentView view, IAssignmentRepository repository)
        {
            this.assignmentBindingSource = new BindingSource();
            this.moduleBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            //used in tab1 main
            this.view.SaveAssignEvent += AddAssign;
            this.view.DeleteAssignEvent += DeleteAssign;
            this.view.EditAssignEvent += EditAssign;
            this.view.DisplayModIdNumEvent += DisplayModIdNum;
            

            this.view.SetAssignmentListBindingSource(assignmentBindingSource);
            this.view.SetModuleNameListBindingSource(moduleBindingSource);
            
            LoadAllModulesList();
            this.view.DueDate = DateTime.Today;
            // ###### 
            this.view.Show();
        }

        private void AddAssign(object sender, EventArgs e)
        {
            if (view.IsEdit != true) { view.IsEdit = false; }
            SaveAssign();
        }

        /// <summary>
        /// Binds module list and repository method to display in richtextbox for user selection.
        /// </summary>
        private void LoadAllModulesList()
        {
            moduleNameList = repository.GetAllModules();
            moduleBindingSource.DataSource = moduleNameList;
        }

        /// <summary>
        /// Retrieves module id number and displays in textbox for viewing and retrieval.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayModIdNum(object sender, EventArgs e)
        {
            string name = view.SelectedModName;                
            int displayedModId = repository.GetModIdNum(name);  
            view.ModIdNum = displayedModId.ToString();                   
            //display assignments with idnum retrieved
            LoadAllAssignList();                               
        }

        /// <summary>
        /// Retrieves module id number from textbox and passes to repository method to display module specific assignments. 
        /// </summary>
        private void LoadAllAssignList()
        {
            int id = Convert.ToInt32(view.ModIdNum);
            assignmentList = repository.GetAllAssignments(id);
            assignmentBindingSource.DataSource = assignmentList;
        }
        
        /// <summary>
        /// Displays data in textboxes for editing to then be called in the save method. IsEdit bool changed to true.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditAssign(object sender, EventArgs e)
        {
            var res = (AssignmentModel)assignmentBindingSource.Current;
            if (res != null)
            {
                view.AssignIdNum = res.Assign_IdNum.ToString();
                view.AssignName = res.Assign_Name;
                view.DueDate = res.Due_Date.Date;
                view.Trimester = Convert.ToDecimal(res.Assign_Trimester);
                view.ModIdNum = res.Mod_IdNum.ToString();
                view.IsEdit = true;
            }
        }

        /// <summary>
        /// Deletes row in assignment list and updates sql database using sql method in repository.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteAssign(object sender, EventArgs e)
        {
            try
            {
                var res = (AssignmentModel)assignmentBindingSource.Current;
                if (res != null)
                {
                   
                    repository.Delete(res.Assign_IdNum);
                    view.IsSuccessful = true;
                    view.Message = "Assignment and resources deleted successfully";
                    ClearAllTextFields();
                    LoadAllAssignList();
                }
                else
                {
                    view.Message = "Please select an assignment that exists";
                    return;
                }
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Sorry, could not delete the assignment due to an error.\nCheck if any resources need deleting and try again.\n"+ex.Message;
            }
        }
        /// <summary>
        /// Combines edit and save function using bool isEdit status. Calls sql methods from repository to amend list and update database.
        /// </summary>
        private void SaveAssign()
        {
            var model = new AssignmentModel();
            try
            {
                if (view.AssignIdNum != "") 
                { 
                    //for editing not new 
                    model.Assign_IdNum = int.Parse(view.AssignIdNum); 
                }
                model.Assign_Name = view.AssignName;
                model.Due_Date =(DateTime)view.DueDate;
                model.Assign_Trimester = (int)view.Trimester;
                int modId = int.Parse(view.ModIdNum);
                model.Mod_IdNum = modId;
            

                //takes validation requirements in ie resource models to validate input fields
                //throws exception with set message if incorrect input
                new Common.ModelDataValidation().Validate(model); //################### used for mvc (web based) not mvp 
                //runs ok without it but no model validation
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.IsEdit = false;
                    view.Message = "Assignment edited successfully";
                    
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Assignment added successfully";
                }
                view.IsSuccessful = true;
                LoadAllAssignList();
                ClearAllTextFields();
            }
            catch (FormatException ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message + " No details entered please try again";
                MessageBox.Show("No details entered, please try again");
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
                MessageBox.Show("Error saving/editing-> " + ex.Message, "Saving/Editing");
            }
            
        }
        /// <summary>
        /// Used in saveResource(), cancelAction(), to clear all textboxes of data.
        /// </summary>
        private void ClearAllTextFields()
        {
            view.AssignIdNum = "";
            view.AssignName = "";
        }

        
    }
}
