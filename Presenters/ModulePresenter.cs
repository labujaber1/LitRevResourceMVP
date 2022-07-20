using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LitRevResourceMVP.Models;
using LitRevResourceMVP.Views;

namespace LitRevResourceMVP.Presenters
{
    public class ModulePresenter
    {
        private IModuleView view;
        private IModuleRepository repository;
        private BindingSource moduleBindingSource;
        private IEnumerable<ModuleModel> moduleList;

        /// <summary>
        /// Setup events args to event handlers and module bindings source. 
        /// </summary>
        /// <param name="view"></param>
        /// <param name="repository"></param>
        public ModulePresenter(IModuleView view, IModuleRepository repository)
        {
            this.moduleBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            //used in tab1 main
            this.view.AddModEvent += SaveModule;
            this.view.DeleteModEvent += DeleteModule;
            this.view.EditModEvent += EditModule;

            this.view.SetModuleListBindingSource(moduleBindingSource);
            LoadAllModuleList();
            // ###### 
            this.view.Show();
        }

        /// <summary>
        /// Combines edit and save function using bool isEdit status. Calls sql methods from repository to amend list and update database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveModule(object sender, EventArgs e)
        {
            var model = new ModuleModel();
            if (view.ModIdNum != "") 
            { 
                //view.IsEdit = false; 
                model.Mod_IdNum = Convert.ToInt32(view.ModIdNum);
               
            }
            model.Mod_Name = view.ModName;
            model.Mod_DateYear = view.ModDateYear;

            try
            {
                //takes validation requirements in ie resource models to validate input fields
                //throws exception with set message if incorrect input
                //new Common.ModelDataValidation().Validate(model); //##################
                if (view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Module edited successfully";
                }
                else
                {
                    repository.Add(model); //throws error column name not match table missing date set to not null
                    view.Message = "Module added successfully";
                }
                view.IsSuccessful = true;
                LoadAllModuleList();
                ClearAllTextFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Deletes row in module list and updates sql database using sql method in repository
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteModule(object sender, EventArgs e)
        {
            try
            {
                var res = (ModuleModel)moduleBindingSource.Current;
                if (res != null)
                {
                    repository.Delete(res.Mod_IdNum);
                    view.IsSuccessful = true;
                    view.Message = "Module and associated resources deleted successfully";
                    LoadAllModuleList();
                }

            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message = "Sorry, could not delete the module due to an error";
            }
        }
        /// <summary>
        /// Stores edited data to be called in savemodule for datbase and list update.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditModule(object sender, EventArgs e)
        {
            var res = (ModuleModel)moduleBindingSource.Current;
            if (res != null)
            {
                view.ModIdNum = res.Mod_IdNum.ToString();
                view.ModName = res.Mod_Name;
                view.ModDateYear = res.Mod_DateYear.ToString();
                view.IsEdit = true;
            }
        }

        
        /// <summary>
        /// Binds module list to repository method for display in richtextbox.
        /// </summary>
        private void LoadAllModuleList()
        {
            moduleList = repository.GetAllModules();
            moduleBindingSource.DataSource = moduleList;
        }

        /// <summary>
        /// Used in saveResource(), cancelAction(), to clear all textboxes of data.
        /// </summary>
        private void ClearAllTextFields()
        {
            view.ModIdNum = "0";
            view.ModName = "";
            view.ModDateYear = "";
            
        }



    }
}
