using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors.ViewInfo;

namespace dxSample_CustomSimpleButton.Custom_Button {
    public class CustomSimpleButtonViewInfo : SimpleButtonViewInfo {
        public CustomSimpleButtonViewInfo(DevExpress.XtraEditors.SimpleButton owner)
            : base(owner) {
        }
        protected override DevExpress.XtraEditors.Drawing.EditorButtonPainter GetButtonPainter() {
            return new CustomSkinEditorButtonPainter(LookAndFeel.ActiveLookAndFeel, Owner);
        }
    }
}
