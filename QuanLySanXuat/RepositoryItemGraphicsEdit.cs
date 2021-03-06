using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using QuanLySanXuat.GraphicsEditor;


namespace QuanLySanXuat
{
	namespace GraphicsEditor
	{
		//The attribute that points to the registration method
	    [UserRepositoryItem("RegisterGraphicsEditor")]
	    public
	        class RepositoryItemGraphicsEdit : RepositoryItemPictureEdit
	    {
	        // Static constructor should call registration method
	        static RepositoryItemGraphicsEdit()
	        {
	            RegisterGraphicsEditor();
	        }

	        public const string GraphicsEditorName = "GraphicsEdit";

	        public override string EditorTypeName
	        {
	            get { return GraphicsEditorName; }
	        }

	        public static void RegisterGraphicsEditor()
	        {
	            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(GraphicsEditorName, typeof(GraphicsEdit),
	                typeof(RepositoryItemGraphicsEdit), typeof(GraphicsEditViewInfo), new PictureEditPainter(), true));
	        }
	    }
	}
}
