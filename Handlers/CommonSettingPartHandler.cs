using Codesanook.Common.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Localization;

namespace Codesanook.Configuration.Handlers {
    public class CommonSettingPartHandler : ContentHandler {
        public Localizer T { get; set; }

        private const string groupId = "Common settings";

        public CommonSettingPartHandler() {
            T = NullLocalizer.Instance;

            // Attach a part to a content item Site
            Filters.Add(new ActivatingFilter<CommonSettingPart>("Site"));

            // Set a view for content part 
            Filters.Add(new TemplateFilterForPart<CommonSettingPart>(
               prefix: "CommonSetting",
               templateName: "Parts/CommonSetting", // Part in EditorTemplates
               groupId: groupId // Same as name parameter of GroupInfo but ignore case
            ));
        }

        protected override void GetItemMetadata(GetContentItemMetadataContext context) {
            if (context.ContentItem.ContentType != "Site") {
                return;
            }

            base.GetItemMetadata(context);
            context.Metadata.EditorGroupInfo.Add(new GroupInfo(T(groupId)));
        }
    }
}
