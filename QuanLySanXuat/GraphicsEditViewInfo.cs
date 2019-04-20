// VBConversions Note: VB project level imports
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System.Windows.Forms;
// End of VB project level imports

using System.Text;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Repository;



namespace QuanLySanXuat
		{
			namespace GraphicsEditor
			{
				public class GraphicsEditViewInfo : PictureEditViewInfo
				{
					public GraphicsEditViewInfo(RepositoryItem item) : base(item)
					{
					}
			
			public override dynamic EditValue
			{
				get
				{
					return base.EditValue;
				}
				set
				{
					if (value != null && value.GetType() == typeof(System.String))
					{
						try
						{
							base.EditValue = new Bitmap(value.ToString());
						}
						catch
						{
							base.EditValue = Item.ErrorImage;
						}
					}
					else
					{
						base.EditValue = value;
					}
				}
			}
		}
	}
	
}
