﻿namespace PnP.Framework.Provisioning.Model
{
    /// <summary>
    /// Defines a collection of objects of type WorkflowDefinition
    /// </summary>
    public partial class WorkflowDefinitionCollection : BaseProvisioningTemplateObjectCollection<WorkflowDefinition>
    {
        /// <summary>
        /// Constructor for WorkflowDefinitionCollection class
        /// </summary>
        /// <param name="parentTemplate">Parent provisioning template</param>
        public WorkflowDefinitionCollection(ProvisioningTemplate parentTemplate) :
            base(parentTemplate)
        {
        }
    }
}
