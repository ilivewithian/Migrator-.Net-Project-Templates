using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TemplateWizard;
using EnvDTE;

namespace Migrator.Net_Templates
{
    public class MigrationTemplate : IWizard
    {
        // Methods
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        public void RunFinished()
        {
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            if (replacementsDictionary.ContainsKey("$migrationId$"))
            {
                replacementsDictionary["$migrationId$"] = string.Format("{0:yyyyMMddhhssfff}", DateTime.Now);
            }
            else
            {
                replacementsDictionary.Add("$migrationId$", string.Format("{0:yyyyMMddhhssfff}", DateTime.Now));
            }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return false;
        }
    }
}
