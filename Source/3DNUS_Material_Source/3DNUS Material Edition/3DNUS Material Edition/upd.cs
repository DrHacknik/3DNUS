using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _3DNUS_Material_Edition
{
    internal class upd

    {
        private static bool TryToDelete(string f)
        {
            try
            {
                // A.
                // Try to delete the file.
                File.Delete("3DNUS.old.exe");
                return true;
            }
            catch (IOException)
            {
                // B.
                // We could not delete the file.
                return false;
            }
        }
    }
}