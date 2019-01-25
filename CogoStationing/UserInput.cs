using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.DatabaseServices;

namespace CogoStationing
{
    public class UserInput
    {
        public static ObjectId GetAlignmentId(ref Editor ed, string message)
        {
            PromptEntityOptions options = new PromptEntityOptions("\n" + message);
            options.SetRejectMessage("\n You must select an alignment \n");
            options.AddAllowedClass(typeof(Alignment), true);
            ObjectId alignId = ed.GetEntity(options).ObjectId;
            return alignId;
        }
    }
}
