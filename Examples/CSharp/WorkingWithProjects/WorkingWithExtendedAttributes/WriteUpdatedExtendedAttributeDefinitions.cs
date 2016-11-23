using System;
using Aspose.Tasks.Saving;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithExtendedAttributes
{
    public class WriteUpdatedExtendedAttributeDefinitions
    {
        public static void Run()
        {
            // This example requires Aspose.Task for .NET, a trial version can be download from  http://www.aspose.com/corporate/purchase/temporary-license.aspx
            try
            {
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName);

                // ExStart:WriteUpdatedExtendedAttributeDefinitions
                Project project = new Project(dataDir + "WriteUpdatedExtendedAttributeDefinitions.mpp");

                #region task attributes
                // Add new text3 extended attribute and one text value
                ExtendedAttributeDefinition taskTextAttr = new ExtendedAttributeDefinition();
                taskTextAttr.Alias = "New text3 attribute";
                taskTextAttr.FieldName = "Text3";
                taskTextAttr.ElementType = ElementType.Task;
                taskTextAttr.CfType = CustomFieldType.Text;
                taskTextAttr.FieldId = Convert.ToInt32(ExtendedAttributeTask.Text3).ToString();
                taskTextAttr.LookupUid = Guid.NewGuid().ToString();
                project.ExtendedAttributes.Add(taskTextAttr);

                Value textVal = new Value();
                textVal.Id = 1;
                textVal.Description = "Text value descr";
                textVal.Val = "Text value1";
                taskTextAttr.ValueList.Add(textVal);

                // Add new cost1 extended attribute and two cost values
                ExtendedAttributeDefinition taskCostAttr = new ExtendedAttributeDefinition();
                taskCostAttr.Alias = "New cost1 attribute";
                taskCostAttr.FieldName = "Cost1";
                taskCostAttr.ElementType = ElementType.Task;
                taskCostAttr.CfType = CustomFieldType.Cost;
                taskCostAttr.FieldId = Convert.ToInt32(ExtendedAttributeTask.Cost1).ToString();
                taskCostAttr.LookupUid = Guid.NewGuid().ToString();
                project.ExtendedAttributes.Add(taskCostAttr);

                Value costVal1 = new Value();
                costVal1.Id = 2;
                costVal1.Description = "Cost value 1 descr";
                costVal1.Val = "99900";

                Value costVal2 = new Value();
                costVal2.Id = 3;
                costVal2.Description = "Cost value 2 descr";
                costVal2.Val = "11100";

                taskCostAttr.ValueList.Add(costVal1);
                taskCostAttr.ValueList.Add(costVal2);

                // Add new task and assign attribute value
                Task task = project.RootTask.Children.Add("New task");

                ExtendedAttribute taskAttr = new ExtendedAttribute();
                taskAttr.AttributeDefinition = taskCostAttr;
                taskAttr.Value = "99900";
                taskAttr.FieldId = taskCostAttr.FieldId;
                task.ExtendedAttributes.Add(taskAttr);

                ExtendedAttributeDefinition taskStartAttr = new ExtendedAttributeDefinition();
                taskStartAttr.Alias = "New start 7 attribute";
                taskStartAttr.CfType = CustomFieldType.Start;
                taskStartAttr.ElementType = ElementType.Task;
                taskStartAttr.FieldName = "Start7";
                taskStartAttr.FieldId = Convert.ToInt32(ExtendedAttributeTask.Start7).ToString();
                taskStartAttr.LookupUid = Guid.NewGuid().ToString();
                Value startVal = new Value();
                startVal.Val = DateTime.Now.ToString();
                startVal.Description = "Start 7 value description";

                taskStartAttr.ValueList.Add(startVal);

                project.ExtendedAttributes.Add(taskStartAttr);

                ExtendedAttributeDefinition taskFinishAttr = new ExtendedAttributeDefinition();
                taskFinishAttr.Alias = "New finish 4 attribute";
                taskFinishAttr.CfType = CustomFieldType.Finish;
                taskFinishAttr.ElementType = ElementType.Task;
                taskFinishAttr.FieldName = "Finish4";
                taskFinishAttr.FieldId = Convert.ToInt32(ExtendedAttributeTask.Finish4).ToString();
                taskFinishAttr.LookupUid = Guid.NewGuid().ToString();
                Value finishVal = new Value();
                finishVal.Val = DateTime.Now.ToString();
                finishVal.Description = "Finish 4 value description";

                taskFinishAttr.ValueList.Add(finishVal);

                project.ExtendedAttributes.Add(taskFinishAttr);

                ExtendedAttributeDefinition numberAttr = new ExtendedAttributeDefinition();
                numberAttr.Alias = "New number attribute";
                numberAttr.FieldName = "Number20";
                numberAttr.CfType = CustomFieldType.Number;
                numberAttr.ElementType = ElementType.Task;
                numberAttr.FieldId = Convert.ToInt32(ExtendedAttributeTask.Number20).ToString();
                numberAttr.LookupUid = Guid.NewGuid().ToString();
                Value val1 = new Value();
                val1.Val = "1";
                val1.Description = "Number 1 value";
                Value val2 = new Value();
                val2.Val = "2";
                val2.Description = "Number 2 value";
                Value val3 = new Value();
                val3.Val = "3";
                val3.Description = "Number 3 value";

                numberAttr.ValueList.Add(val1);
                numberAttr.ValueList.Add(val2);
                numberAttr.ValueList.Add(val3);

                project.ExtendedAttributes.Add(numberAttr);

                #endregion

                ExtendedAttributeDefinition rscStartAttr = new ExtendedAttributeDefinition();
                rscStartAttr.Alias = "New start5 attribute";
                rscStartAttr.FieldName = "Start5";
                rscStartAttr.ElementType = ElementType.Resource;
                rscStartAttr.CfType = CustomFieldType.Start;
                rscStartAttr.CalculationType = CalculationType.Rollup;
                rscStartAttr.RollupType = RollupType.Sum;

                rscStartAttr.FieldId = Convert.ToInt32(ExtendedAttributeTask.Start5).ToString(); ;
                rscStartAttr.LookupUid = Guid.NewGuid().ToString();
                Value startVal2 = new Value();
                startVal2.Id = 4;
                startVal2.Val = DateTime.Now.ToString();
                startVal2.Description = "this is start5 value descr";

                rscStartAttr.ValueList.Add(startVal2);

                project.ExtendedAttributes.Add(rscStartAttr);

                ExtendedAttributeDefinition myTaskDurattr = new ExtendedAttributeDefinition();
                myTaskDurattr.Alias = "New Duration";
                myTaskDurattr.CfType = CustomFieldType.Duration;
                myTaskDurattr.FieldId = ExtendedAttributeTask.Duration1.ToString("D");
                myTaskDurattr.CalculationType = CalculationType.Rollup;
                myTaskDurattr.RollupType = RollupType.Sum;
                myTaskDurattr.ElementType = ElementType.Task;
                project.ExtendedAttributes.Add(myTaskDurattr);

                // Add new task and assign attribute value
                Task timeTask = project.RootTask.Children.Add("New task");

                ExtendedAttribute timeexExtendedAttribute = myTaskDurattr.CreateExtendedAttribute();

                timeexExtendedAttribute.DurationFormat = TimeUnitType.Hour;
                timeexExtendedAttribute.Value = "PT3H0M0S";
                timeTask.ExtendedAttributes.Add(timeexExtendedAttribute);

                MPPSaveOptions mppSaveOptions = new MPPSaveOptions();
                mppSaveOptions.WriteViewData = true;

                // Save the project as MPP project file
                project.Save(dataDir + "WriteUpdatedExtendedAttributeDefinitions_out.mpp", mppSaveOptions);
                // ExEnd:WriteUpdatedExtendedAttributeDefinitions
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message + "\nThis example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.");
            }

        }
    }
}