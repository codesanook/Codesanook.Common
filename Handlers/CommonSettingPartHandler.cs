using Codesanook.Common.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Localization;

namespace Codesanook.Configuration.Handlers {
    public class CommonSettingPartHandler : ContentHandler {
        public Localizer T { get; set; }

        public CommonSettingPartHandler() {
            T = NullLocalizer.Instance;

            // Attach part to content item Site
            Filters.Add(new ActivatingFilter<SharedSettingPart>("Site"));

            // Set view for content part 
            Filters.Add(new TemplateFilterForPart<SharedSettingPart>(
               prefix: "SharedSetting",
               templateName: "Parts/SharedSetting", // Part in EditorTemplates
               groupId: "codesanook-common-settings" // Same as name parameter of GroupInfo but ignore case
            ));
        }

        protected override void GetItemMetadata(GetContentItemMetadataContext context) {
            if (context.ContentItem.ContentType != "Site") {
                return;
            }
            base.GetItemMetadata(context);
            context.Metadata.EditorGroupInfo.Add(new GroupInfo(T("Codesanook common settings")));
        }
    }
}
