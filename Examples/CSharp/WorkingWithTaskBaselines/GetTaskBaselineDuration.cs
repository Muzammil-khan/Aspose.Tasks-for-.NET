﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Examples.CSharp.WorkingWithTaskBaselines
{
    class GetTaskBaselineDuration
    {
        public  static void Run()
        {                        
            // ExStart:GetTaskBaselineDuration
            // Create project instance
            Project project = new Project();

            // Creating TaskBaseline
            Task task = project.RootTask.Children.Add("Task");
            project.SetBaseline(BaselineType.Baseline);

            // Display task baseline duration
            TaskBaseline baseline = task.Baselines.ToList()[0];
            Console.WriteLine("Baseline duration is 1 day: {0}", baseline.Duration.ToString().Equals("1 day"));
            Console.WriteLine("BaselineStart is same as Task Start: {0}", baseline.Start.Equals(task.Get(Tsk.Start)));
            Console.WriteLine("BaselineFinish is same as Task Finish: {0}", baseline.Finish.Equals(task.Get(Tsk.Finish)));
            // ExEnd:GetTaskBaselineDuration            
        }
    }
}
