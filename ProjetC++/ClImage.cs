using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;
using System.Drawing;

namespace libImage
{
    public class ClImage
    {
        // on crée une classe C# avec pointeur sur l'objet C++
        // puis des static extern exportées de chaque méthode utile de la classe C++
        public IntPtr ClPtr;

        public ClImage()
        {
            ClPtr = IntPtr.Zero;
        }

        ~ClImage()
        {
            if (ClPtr != IntPtr.Zero)
                ClPtr = IntPtr.Zero;
        }


        // va-et-vient avec constructeur C#/C++
        // obligatoire dans toute nouvelle classe propre à l'application

        [DllImport("libImage.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr objetLib();

        public IntPtr objetLibPtr()
        {
            ClPtr = objetLib();
            return ClPtr;
        }

        [DllImport("libImage.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr objetLibDataImg(int nbChamps, IntPtr dataImage1, int strideImage1, IntPtr dataImage2, int strideImage2, int nbLig, int nbCol, bool imageIn, string typeSE, int largeurSE, int hauteurSE);

        public IntPtr objetLibDataImgPtr(int nbChamps, IntPtr dataImage1, int strideImage1, IntPtr dataImage2, int strideImage2, int nbLig, int nbCol, bool imageIn, string typeSE, int largeurSE, int hauteurSE)
        {
            ClPtr = objetLibDataImg(nbChamps, dataImage1, strideImage1, dataImage2, strideImage2, nbLig, nbCol, imageIn, typeSE, largeurSE, hauteurSE);
            return ClPtr;
        }

        [DllImport("libImage.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double valeurChamp(IntPtr pImg, int i);

        public double objetLibValeurChamp(int i)
        {
            return valeurChamp(ClPtr, i);
        }
    }
}
