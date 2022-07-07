using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LitRevResourceMVP.Models;
using LitRevResourceMVP.Views;

namespace LitRevResourceMVP.Presenters
{
    public class AssignmentPresenter
    {
        private IAssignmentView view;
        private IAssignmentRepository repository;
        private BindingSource assignmentBindingSource;
        private BindingSource moduleBindingSource;
        
        private IEnumerable<AssignmentModel> assignmentList;
        private IEnumerable<string> moduleNameList;
        

        public AssignmentPresenter(IAssignmentView view, IAssignmentRepository repository)
        {
            this.assignmentBindingSource = new BindingSource();
            this.moduleBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            //used in tab1 main
            this.view.SaveAssignEvent += SaveAssign;
            this.view.DeleteAssignEvent += DeleteAssign;
            this.view.EditAssignEvent += EditAssign;
            this.view.DisplayModIdNumEvent += DisplayModIdNum;
            

            this.view.SetAssignmentListBindingSource(assignmentBindingSource);
            this.view.SetModuleNameListBindingSource(moduleBindingSource);
            
            LoadAllModulesList();
            
            // ###### 
            this.view.Show();
        }

        
        private void LoadAllModulesList()
        {
            moduleNameList = repository.GetAllModules();
            moduleBindingSource.DataSource = moduleNameList;

        }

        //click event
        private void DisplayModIdNum(object sender, EventArgs e)
        {
            string name = view.SelectedModName;                
            int displayedModId = repository.GetModIdNum(name);  
            view.ModIdNum = displayedModId.ToString();                   
            //display assignments with idnum retrieved
            LoadAllAssignList();                               
        }

 
        private void LoadAllAssignList()
        {
            int id = Convert.ToInt32(view.ModIdNum);
            assignmentList = repository.GetAllAssignments(id);
            assignmentBindingSource.DataSource = assignmentList;
        }
        

        private void EditAssign(object sender, EventArgs e)
        {
            var res = (AssignmentModel)assignmentBindingSource.Current;
            if (res != null)
            {
                view.AssignIdNum = res.Assign_IdNum.ToString();
                view.AssignName = res.Assign_Name;
                view.DueDate = res.Due_Date;
                view.Trimester = res.Assign_Trimester.ToString();
                view.ModIdNum = res.Mod_IdNum.ToString();
                view.IsEdit = true;
            }
        }

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
                    LoadAllAssignList();
                }
                else
                {
                    view.Message = "Please select an assignment that exists";
                    return;
                }
            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message = "Sorry, could not delete the assignment due to an error";
            }
        }

        private void SaveAssign(object sender, EventArgs e)
        {
            var model = new AssignmentModel();
            
            if (view.AssignIdNum != "") 
            { 
                //view.IsEdit = false; 
                model.Assign_IdNum = int.Parse(view.AssignIdNum); 
            }
            model.Assign_Name = view.AssignName;
            model.Due_Date = view.DueDate;
            model.Assign_Trimester = int.Parse(view.Trimester);
            model.Mod_IdNum = int.Parse(view.ModIdNum); 

            try
            {
                //takes validation requirements in ie resource models to validate input fields
                //throws exception with set message if incorrect input
                //new Common.ModelDataValidation().Validate(model); //###################
                //causes error, cannot cast int32 to string...bugger!
                //maybe date issue model--> datetime but input--> date only, changed model datatype still error
                //runs ok without it
                if (view.IsEdit)
                {
                    repository.Edit(model);
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
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
                MessageBox.Show("Error saving/editing-> " + ex.Message, "Saving/Editing");
            }
        }
        //used in saveResource(), cancelAction(), 
        private void ClearAllTextFields()
        {
            view.AssignIdNum = "";
            view.AssignName = "";
            //view.DueDate = "";
            view.Trimester = "";
        }

        
    }
}
