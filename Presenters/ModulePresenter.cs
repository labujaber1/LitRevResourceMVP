using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                new Common.ModelDataValidation().Validate(model);
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

        private void DeleteModule(object sender, EventArgs e)
        {
            try
            {
                var res = (ModuleModel)moduleBindingSource.Current;
                repository.Delete(res.Mod_IdNum);
                view.IsSuccessful = true;
                view.Message = "Module and associated resources deleted successfully";
                LoadAllModuleList();
            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message = "Sorry, could not delete the module due to an error";
            }
        }

        private void EditModule(object sender, EventArgs e)
        {
            var res = (ModuleModel)moduleBindingSource.Current;
            view.ModIdNum = res.Mod_IdNum.ToString();
            view.ModName = res.Mod_Name;
            view.ModDateYear = res.Mod_DateYear.ToString();
            view.IsEdit = true;
        }

        

        private void LoadAllModuleList()
        {
            moduleList = repository.GetAllModules();
            moduleBindingSource.DataSource = moduleList;
        }

        //used in saveResource(), cancelAction(), 
        private void ClearAllTextFields()
        {
            view.ModIdNum = "0";
            view.ModName = "";
            view.ModDateYear = "";
            
        }



    }
}
