﻿using Aspose.Tasks.Saving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithResources
{
    class UpdateResourceDataInMPP
    {
        public static void Run()
        {
            try
            {
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

                // ExStart:UpdateResourceDataInMPP
                // Create project instance
                Project project1 = new Project(dataDir + "UpdateResourceData.mpp");

                // Add resource and set some properties
                Resource rsc1 = project1.Resources.Add("Rsc");
                rsc1.Set(Rsc.StandardRate, 30);
                rsc1.Set(Rsc.OvertimeRate, 45);
                rsc1.Set(Rsc.Group, "Workgroup1");

                // Save the Project
                project1.Save(dataDir + "UpdateResourceData_out.mpp", SaveFileFormat.MPP);
                // ExEnd:UpdateResourceDataInMPP
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
