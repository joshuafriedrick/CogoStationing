using System;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.EditorInput;

// This line is not mandatory, but improves loading performances
[assembly: CommandClass(typeof(CogoStationing.CogoStationingCommands))]

namespace CogoStationing
{

    // This class is instantiated by AutoCAD for each document when
    // a command is called by the user the first time in the context
    // of a given document. In other words, non static data in this class
    // is implicitly per-document!
    public class CogoStationingCommands
    {
        // The CommandMethod attribute can be applied to any public  member 
        // function of any public class.
        // The function should take no arguments and return nothing.
        // If the method is an intance member then the enclosing class is 
        // intantiated for each document. If the member is a static member then
        // the enclosing class is NOT intantiated.
        //
        // NOTE: CommandMethod has overloads where you can provide helpid and
        // context menu.

        // Modal Command with localized name
        [CommandMethod("CogoStationing", "MyCommand", "MyCommandLocal", CommandFlags.Modal)]
        public void CogoStationingCommand() // This method can have any name
        {
            // Put your command code here
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;
            if (doc != null)
            {
                ed.WriteMessage("CogoStationing by Joshua Friedrick");
            }
            // Set the focus to the drawing area
            Autodesk.AutoCAD.Internal.Utils.SetFocusToDwgView();

            // Get the current database and start the transaction manager
            Database db = doc.Database;

            // Get an alignment object id
            ObjectId alignmentId;
        }
    }
}
