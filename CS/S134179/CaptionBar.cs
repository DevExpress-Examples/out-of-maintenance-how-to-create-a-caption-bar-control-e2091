using System;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.Utils.Drawing;

namespace S134179 {
    public class CaptionBar:GroupControl {
        public CaptionBar() : base() { }

        protected override ObjectPainter CreatePainter() {
            switch (LookAndFeel.ActiveStyle) {
                case ActiveLookAndFeelStyle.Office2003: return new CaptionBarObjectPainter(this);
                case ActiveLookAndFeelStyle.WindowsXP: return new WindowsXPCaptionBarObjectPainter(this);
                case ActiveLookAndFeelStyle.Skin: 
                    return new SkinCaptionBarObjectPainter(this, LookAndFeel);
            }
            return new FlatCaptionBarObjectPainter(this);
        }
    }

    public class SkinCaptionBarObjectPainter :SkinGroupObjectPainter {
        public SkinCaptionBarObjectPainter(IPanelControlOwner owner, ISkinProvider provider) 
            : base(owner, provider) { }

        protected override int CalcCaptionContentHeight(GroupObjectInfoArgs info) {
            return info.Bounds.Height;
        }

        protected override void CalcCaptionNew(GroupObjectInfoArgs info) {
            info.CaptionBounds = info.Bounds;
            CalcCaptionElements(info, info.Bounds);
        }
    }

    public class CaptionBarObjectPainter :GroupObjectPainter {
        public CaptionBarObjectPainter(IPanelControlOwner owner) : base(owner) { }

        protected override int CalcCaptionContentHeight(GroupObjectInfoArgs info) {
            return info.Bounds.Height;
        }

        protected override void CalcCaptionNew(GroupObjectInfoArgs info) {
            info.CaptionBounds = info.Bounds;
            CalcCaptionElements(info, info.Bounds);
        }
    }

    public class WindowsXPCaptionBarObjectPainter :WindowsXPGroupObjectPainter {
        public WindowsXPCaptionBarObjectPainter(IPanelControlOwner owner) : base(owner) { }

        protected override int CalcCaptionContentHeight(GroupObjectInfoArgs info) {
            return info.Bounds.Height;
        }

        protected override void CalcCaptionNew(GroupObjectInfoArgs info) {
            info.CaptionBounds = info.Bounds;
            CalcCaptionElements(info, info.Bounds);
        }
    }

    public class FlatCaptionBarObjectPainter :FlatGroupObjectPainter {
        public FlatCaptionBarObjectPainter(IPanelControlOwner owner) : base(owner) { }

        protected override int CalcCaptionContentHeight(GroupObjectInfoArgs info) {
            return info.Bounds.Height;
        }

        protected override void CalcCaptionNew(GroupObjectInfoArgs info) {
            info.CaptionBounds = info.Bounds;
            CalcCaptionElements(info, info.Bounds);
        }
    }
}
