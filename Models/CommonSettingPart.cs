using Orchard.ContentManagement;

namespace Codesanook.Common.Models {
    public class CommonSettingPart : ContentPart {

        public string AwsAccessKey {
            get => this.Retrieve(x => x.AwsAccessKey);
            set => this.Store(x => x.AwsAccessKey, value);
        }

        public string AwsSecretKey {
            get => this.Retrieve(x => x.AwsSecretKey);
            set => this.Store(x => x.AwsSecretKey, value);
        }

        public string FacebookAppId {
            get => this.Retrieve(x => x.FacebookAppId);
            set => this.Store(x => x.FacebookAppId, value);
        }

        public virtual string GoogleServiceAccountP12Key {
            get => this.Retrieve(x => x.GoogleServiceAccountP12Key);
            set => this.Store(x => x.GoogleServiceAccountP12Key, value);
        }
    }
}
