﻿using System;
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
        // This property allows you to enable the command in Cimatron

        public void Execute()
        {

            interop.CimServicesAPI.CimApplicationProvider AppProvider = new interop.CimServicesAPI.CimApplicationProvider();
            interop.CimatronE.IApplication cimApp = AppProvider.GetApplication();

            cimbase.IPoolCommands pool = (cimbase.IPoolCommands)cimApp.GetPoolCommands();

            cimbase.ICimCommand section = pool.GetCommand("Tools2", "Dynamic Section");
            section.Execute();
             

            cimmod.ICimDocument cimdoc = (cimmod.ICimDocument)cimApp.GetActiveDoc();

            

            MessageBox.Show("New custom title created today!", "Custom Title", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
        //This property allows you to set the Category Name of your own command.
        public string GetCategoryName()

        {

            return "NEW CIMATRON CATEGORY";

        }

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




