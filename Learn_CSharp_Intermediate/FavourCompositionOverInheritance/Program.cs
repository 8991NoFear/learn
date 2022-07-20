using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavourCompositionOverInheritance
{
    /*
     * Relationships:
     *  +, Is-A => Inheritance
     *  +, Have-A => Composition
     * 
     * Inheritance problems: easily abused and larger hierarchies
     * 
     * Compostion benefits:
     *  +, Flexibility: target prop can be null or list of objects
     *  +, Loose coupling: target prop can be an interface
     * 
     * Any inheritance relationship can always be translated to composition. In real world 
     * if there is a is-a relationship doesn't mean you have to model it using inheritane
     */
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger()); // Composition
            dbMigrator.Migrate();

            var logger = new Logger();
            var installer = new Installer(logger); // Aggregation
            installer.Install();
        }

    }
}
