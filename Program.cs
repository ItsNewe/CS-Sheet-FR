using System; //Utilise le répertoire "System", qui permet de faire [Console.wrt(**);" plutot que "System.Console.wrt(System.***);"
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        //une énumération démarre à 1 et ajoute +1 à la valeur précédente et crée une nouvelle variable, passage a la valeur indiquée si présente
        enum Jours
        {
            Lundi = 5, // lundi vaut 5
            Mardi, // mardi vaut 6
            Mercredi = 9, // mercredi vaut 9
            Jeudi = 10, // jeudi vaut 10
            Vendredi, // vendredi vaut 11 
            Samedi, // samedi vaut 12
            Dimanche = 20 // dimanche vaut 20
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Logged in as " + Environment.UserName);

            WelcomeText("Newe");

            int compteur;
            for (compteur = 0; compteur < 10; compteur++)
            {
                Console.WriteLine(compteur + "%");
            }

            /* int = entier
             * string = chaine de caractères, écrit ""
             * decimal = chiffre a virgule multiple
             * double = virgule
             * char = 1 caractère, écrit ''
             * bool = true\false */

            int thing = 30;
            Console.WriteLine(thing); //affiche 30
            thing = 20;
            Console.WriteLine(thing); //affiche 20, car la valeur à changé
            string nom = "Newe";
            decimal compte = 100;
            bool estVrai = true;

            int result = 2 * 3;
            Console.WriteLine(result); //affiche 6

            //Les strings servent a contenir des chaines de caracteres

            string codepostal = "20221";
            string ville = "Cervione";
            string adresse = codepostal + " " + ville;
            Console.WriteLine(adresse);

            int age = 20;
            age = age + 10; // age contient 30 (addition)
            age++; // age contient 31 (incrémentation de 1)
            age--; // age contient 30 (décrémentation de 1)
            age += 10; // équivalent à age = age + 10 (age contient 40)
            age /= 2; // équivalent à age = age / 2 => (age contient 20)

            int moyenne = (thing + age) / 2; //Ne pas oublier les parenthèses prioritaires

            int moy = 5 / 2; //Cela va sortir 2 même si le resultat est 2.5 car ce sont des entiers, arrondi dessous, il faut des doubles >
            double moy2 = 5.0 / 2.0; //correct
            Console.WriteLine(moy2);

            //Caractères spéciaux  ("" ferme un string)
            // [\n] sert à passe à la ligne 
            string phrase = " Mon\n nom\n est\n \"Newe\"";

            {
                // \t sert à faire un TAB
                Console.WriteLine("Choses à faire:");
                Console.WriteLine("\t - Manger");
                Console.WriteLine("\t - Dormir");
            }

            {
                //Pour afficher un "\" il suffit de le mettre 2 fois
                string saas = "\\saas\\";
                Console.WriteLine(saas);
            }

            //pour un path, on peut rajout er @ devant le ""
            string pathtopone = @"C:\Users\User\Desktop\Pone";
            Console.WriteLine(pathtopone);

            //Pour passer à la ligne, on peut utiliser "Environement.NewLine"
            Console.WriteLine("Passer" + Environment.NewLine + "à la ligne"); //2ns string affichée en desdsous

            /* == / Egalité
               != / Différence
               > / Supérieur à
               < / Inférieur à
               >= / Supérieur ou égal
               <= / Inférieur ou égal
               && / ET logique
               ||  /OU logique
               ! / Négation      */
            decimal compteEnBanque = 300;
            if (compteEnBanque <= 50)
                Console.WriteLine("Vous êtes dans le rouge");
            if (compteEnBanque >= 50)
                Console.WriteLine("Tout est OK");

            string userType = "Admin";
            if (userType == "Admin")
                Console.WriteLine("UserGroup : Admin");
            else
                Console.WriteLine("UserGroup: Global");

            //test du bool
            int ageIs = 21;
            bool major = ageIs >= 18; //Si age +18, la valeur est [true]
            if (major) //Si la valuer est [true], [if] est executé
                Console.WriteLine("Access Granted");
            else
                Console.WriteLine("Access Denied");

            string login = "NewePone";
            string pass = "what";
            if (login == "NewePone" && pass == "what")//Les deux sont corrects
                Console.WriteLine("Bienvenue NewePone");
            else if (login != "NewePone" && pass == "what")//Le login est érroné
                Console.WriteLine("Identifiant Incorrect");
            else if (login == "NewePone" && pass != "what")//Le pass est érroné
                Console.WriteLine("Mot de passse incorrect");
            else if (login != "NewePone" && pass != "what")//Les deux sont érronés
                Console.WriteLine("Ce compte n'existe pas");

            //Les switches permettent de simplifier les objets a multiples valeurs
            string civilite = "M.";
            switch (civilite)
            {
                case "M.":
                    Console.WriteLine("Bonjour monsieur");
                    break;
                case "Mme":
                    Console.WriteLine("Bonjour madame");
                    break;
                case "Alien":
                case "ET":
                    Console.WriteLine("Etes-vous humain");
                    break;
                default:
                    Console.WriteLine("Bonjour inconnu");
                    break;
            }
            string contentType = "Lewd";

            //Utilisation des {}

            if (contentType == "Lewd")
            {
                Console.WriteLine("This i like");
            }
            else
            {
                Console.WriteLine("SFW shit");
                Console.WriteLine("wyd seriously");
                int bruhbruhbruh = 97; //Cette valeur ne pourra pas être utilisée plus haut, car le {} est fermé
            }


            {
                List<int> chiffres = new List<int>(); // création de la liste,<int> déclare le type de la liste (decimal, string...)
                chiffres.Add(8); // chiffres contient 8
                chiffres.Add(9); // chiffres contient 8, 9
                chiffres.Add(4); // chiffres contient 8, 9, 4

                chiffres.RemoveAt(1); // chiffres contient 8, 4

                foreach (int chiffre in chiffres)
                {
                    Console.WriteLine(chiffre);
                }
            }
            Jours jourdelasemaine = Jours.Dimanche;
            if (jourdelasemaine == Jours.Dimanche || jourdelasemaine == Jours.Samedi)
            {
                Console.WriteLine("Bon Week-End!");
            }
            int indice;
            for (indice = 0; indice < jours.Length; indice++)
            {
                Console.WriteLine(jours[indice]);
            }
            
        }
        
        // LES METHODES

        static void WelcomeText(string nom)
        {
            if (nom == "")
                return;
            Console.WriteLine("ID: " + nom);
            Console.Write("Starting test program");
            Console.WriteLine(Environment.NewLine);
        }

        //[] signifie un tableau, qui sert a stocker plusieurs variables, accessibles par [(n°)]
        static string[] jours = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };


    }
}
        