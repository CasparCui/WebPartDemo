using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Workflow;
using Microsoft.SharePoint.WorkflowActions;
using System.Activities;

namespace WebPartDemo.Workflow1
{
    public sealed partial class Workflow1 : StateMachineWorkflowActivity
    {
        public Workflow1()
        {
            InitializeComponent();
        }

        public SPWorkflowActivationProperties workflowProperties = new SPWorkflowActivationProperties();

        private void onWorkflowActivated1_Invoked(object sender, ExternalDataEventArgs e)
        {

        }

        private void ApproveNeed(object sender, ConditionalEventArgs e)
        {
            if (workflowProperties.InitiationData == "TestWorkflow")
            {
                e.Result = true;
                logToHistoryListActivity2_HistoryOutcome1 = "hehehehe";

            }
            else
            {
                e.Result = false;
                logToHistoryListActivity3_HistoryOutcome1 = "1";

            }
        }

        public SPWorkflowTaskProperties createTask1_TaskProperties1 = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public Guid createTask1_TaskId1 = default(System.Guid);

        private void setState1_MethodInvoking(object sender, EventArgs e)
        {

        }

        private void createTask1_MethodInvoking(object sender, EventArgs e)
        {
            createTask1_TaskId1 = Guid.NewGuid();
            createTask1_TaskProperties1.Title = "TestWorkflow";
            createTask1_TaskProperties1.AssignedTo = @"caspar\hwcui";
            createTask1_TaskProperties1.DueDate = DateTime.Now.AddDays(3);
            logToHistoryListActivity1_HistoryOutcome1 = "into step 1";
        }

        public string logToHistoryListActivity1_HistoryOutcome1 = default(System.String);
        public SPWorkflowTaskProperties onTaskChanged1_AfterProperties1 = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();
        public SPWorkflowTaskProperties onTaskChanged1_BeforeProperties1 = new Microsoft.SharePoint.Workflow.SPWorkflowTaskProperties();

        private void onTaskChanged1_Invoked(object sender, ExternalDataEventArgs e)
        {
            onTaskChanged1_AfterProperties1 = onTaskChanged1.AfterProperties;
            onTaskChanged1_BeforeProperties1 = onTaskChanged1.BeforeProperties;
        }

        private void IsApproved(object sender, ConditionalEventArgs e)
        {
            if (onTaskChanged1_AfterProperties1.PercentComplete == 1.0)
            {
                e.Result = true;

            }
            else
            {
                e.Result = false;

            }
        }

        private void logToHistoryListActivity2_MethodInvoking(object sender, EventArgs e)
        {

        }

        public string logToHistoryListActivity2_HistoryOutcome1 = default(System.String);
        public string logToHistoryListActivity3_HistoryOutcome1 = default(System.String);
    }
}
