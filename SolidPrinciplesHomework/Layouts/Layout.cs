using SolidPrinciplesHomework.Interfaces;

namespace SolidPrinciplesHomework.Layouts
{
    public abstract class Layout:ILayout
    {
      
        public abstract string Format(string message, string status);

    }
}
