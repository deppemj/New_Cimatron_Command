using System;
using System.IO;
using cimapp = interop.CimAppAccess;
using cimbase = interop.CimBaseAPI;
using cimmod = interop.CimMdlrAPI;
using cime = interop.CimatronE;
using cimmisc = interop.CIMMiscAPI;
using System.Windows.Forms;

namespace New_Cimatron_Command
{

    public class new_cimatron_command : cimbase.ICimCommand, cimbase.ICreateCommand

    {
        //This is the code that runs when the button is pressed in Cimatron
        public void Execute()
        {
            //Getting the application provider
            interop.CimServicesAPI.CimApplicationProvider AppProvider = new interop.CimServicesAPI.CimApplicationProvider();
            
            //Getting the application
            interop.CimatronE.IApplication cimApp = AppProvider.GetApplication();

            //Getting the pool commands object so that i can run many easy commands just by getting their name
            cimbase.IPoolCommands pool = (cimbase.IPoolCommands)cimApp.GetPoolCommands();

            //Getting a command to start a section
            cimbase.ICimCommand section = pool.GetCommand("Tools2", "Dynamic Section");

            //Executing the dynamic section pool command, this runs the command
            section.Execute();
             
            //This gets the active doc if you want to save it or do some other command with the document
            cimmod.ICimDocument cimdoc = (cimmod.ICimDocument)cimApp.GetActiveDoc();
            
            //This sends a message box to the user to show that other commands are allowed since this is a .net program
            MessageBox.Show("New custom title created today!", "Custom Title", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        //This property allows you to set the Category Name of your own command.
        public string GetCategoryName()

        {

            return "NEW CIMATRON CATEGORY";

        }

        // This property allows you to enable the command in Cimatron
        public int Enable()
        {
            return 1; // return true
        }

        // This property allows you to set the Command Name of your own command.
        public string GetCommandName()

        {


            return "NEW CIMATRON COMMAND";

        }
        // This property allows you to set the location of your own command in Cimatron menus.
        public string GetMenuPath()

        {



            return "Tools" + "\n" + "New SubCategory";

        }
        // This property allows you to set the string that will be shown in the status bar of Cimatron.
        public string GetPrompt()

        {


            return "Status Bar Prompt";

        }


        // This property allows you to set the Toolbar title of your own command.
        public string GetToolbarName()

        {

            return "Toolbar Name";

        }
        // This property allows you to set the Tooltip for your own command.
        public string GetTooltip()

        {

            return "Tooltip";

        }
        // This property allows you to set the Description for your own command.
        public string GetDescription()

        {

            return "Description";

        }
        // This property allows you to define the type of file that

        // you can use to view your own Commands.
        public int IsBelongToDoc(cimbase.ECommandCategory iType)
        {
            /*
            // Check current file type, if PART then enable the command.
             if (iType == interop.CimBaseAPI.ECommandCategory.cmCmdPart)               
             {
                 return 1; // True
             }
             else
             {
            // Disable the command on all other file types
                 return 0; //False
             }*/

            return 1;

        }
        // This property allows you to Enable/Disable your own command in the Dropdown Menus.
        public int ShowInMenu()

        {

            return 1; // True

        }
        // This property allows you to Enable/Disable the command in the Toolbar.
        public int ShowInToolbar()

        {

            return 1; // True

        }

    }

}




