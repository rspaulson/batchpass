using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchPass.Client
{
    class PasswordDictionary
    {
        public List<string> passwords;

        public PasswordDictionary(int numWords)
        {
            passwords = Generate(numWords);
        }

        public List<string> Generate(int numWords)
        {
            var passList = new List<string>();
            var adjList = AdjectiveList.adjectives;
            var nounList = NounList.nouns;
            var symbList = SymbolList.symbols;
            Random r = new Random();
            for (int i = 0; i < numWords; i++)
            {

                int rAdj = r.Next(0, adjList.Count);
                int rNoun = r.Next(0, nounList.Count);
                int rNum = r.Next(10, 99);
                int rSymb = r.Next(0, symbList.Count);
                passList.Add(UppercaseFirst(adjList[rAdj]) + UppercaseFirst(nounList[rNoun]) + rNum + symbList[rSymb]);
            }

            return passList;
        }

        private string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
    }
    

    public class WordList
    {
    }

    public static class SymbolList
    {
        public static List<string> symbols = new List<string>
        {
            "!",
            "@",
            "#",
            "$",
            "*"
        };
    }


    public static class AdjectiveList
    {
        public static List<string> adjectives = new List<string>
        {
            #region Appearance
            "attractive",
            "bald",
            "beautiful",
            "chubby",
            "clean",
            "dazzling",
            "drab",
            "elegant",
            "fancy",
            "fit",
            "flabby",
            "glamorous",
            "glossy",
            "gorgeous",
            "handsome",
            "long",
            "magnificent",
            "muscular",
            "plain",
            "plump",
            "quaint",
            "scruffy",
            "shapely",
            "short",
            "skinny",
            "stocky",
            "ugly",
            "unkempt",
            "unsightly",
            #endregion

            #region Colors
            "ashy",
            "black",
            "blue",
            "gray",
            "green",
            "indigo",
            "lemon",
            "mango",
            "orange",
            "purple",
            "red",
            "salmon",
            "white",
            "yellow",
            #endregion

            #region Condition
            "careful",
            "clever",
            "complicated",
            "easy",
            "famous",
            "gifted",
            "gross",
            "hallowed",
            "hollow",
            "helpful",
            "important",
            "interested",
            "inexpensive",
            "mealy",
            "mushy",
            "odd",
            "peaceful",
            "poor",
            "powerful",
            "rich",
            "shy",
            "simple",
            "strong",
            "soggy",
            "soupy",
            "tender",
            "vast",
            "weathered",
            "wrong",
            "weak",
            #endregion

            #region Positive Personality
            "agreeable",
            "ambitious",
            "brave",
            "calm",
            "delightful",
            "eager",
            "excited",
            "faithful",
            "funny",
            "gentle",
            "happy",
            "jolly",
            "kind",
            "lively",
            "nice",
            "obedient",
            "polite",
            "proud",
            "silly",
            "thankful",
            "victorious",
            "witty",
            "wonderful",
            "zealous",
            #endregion

            #region Negative Personality
            "aggressive",
            "angry",
            "bewildered",
            "clumsy",
            "defeated",
            "dull",
            "embarrassed",
            "fierce",
            "frantic",
            "grumpy",
            "gritty",
            "helpless",
            "itchy",
            "jealous",
            "lazy",
            "mysterious",
            "nervous",
            "nosy",
            "obnoxious",
            "pitiful",
            "scary",
            "thoughtless",
            "tricky",
            "worried",
            #endregion

            #region Shape
            "broad",
            "chubby",
            "crooked",
            "curved",
            "deep",
            "flat",
            "high",
            "hollow",
            "low",
            "narrow",
            "refined",
            "round",
            "shallow",
            "skinny",
            "square",
            "steep",
            "straight",
            "wide",
            #endregion

            #region Size
            "big",
            "colossal",
            "enormous",
            "fat",
            "gigantic",
            "great",
            "huge",
            "immense",
            "large",
            "little",
            "mammoth",
            "massive",
            "microscopic",
            "miniature",
            "petite",
            "puny",
            "scrawny",
            "short",
            "small",
            "stout",
            "tall",
            "teeny",
            "tiny",
            #endregion

            #region Sound
            "crashing",
            "deafening",
            "echoing",
            "faint",
            "harsh",
            "hissing",
            "howling",
            "loud",
            "melodic",
            "noisy",
            "purring",
            "quiet",
            "rapping",
            "raspy",
            "rhythmic",
            "screeching",
            "shrilling",
            "singing",
            "squeaking",
            "thundering",
            "wailing",
            "whining",
            "whispering",
            #endregion

            #region Time
            "ancient",
            "brief",
            "early",
            "fast",
            "future",
            "late",
            "long",
            "modern",
            "old",
            "prehistoric",
            "quick",
            "rapid",
            "short",
            "slow",
            "swift",
            "young",
            #endregion

            #region Taste
            "acidic",
            "bitter",
            "bland",
            "cool",
            "creamy",
            "delicious",
            "disgusting",
            "fresh",
            "greasy",
            "juicy",
            "hot",
            "moldy",
            "nutritious",
            "putrid",
            "rancid",
            "ripe",
            "rotten",
            "salty",
            "savory",
            "sour",
            "spicy",
            "spoiled",
            "stale",
            "sweet",
            "tangy",
            "tart",
            "tasteless",
            "tasty",
            "yummy",
            #endregion

            #region Touch
            "breezy",
            "bumpy",
            "chilly",
            "cold",
            "cool",
            "cuddly",
            "damaged",
            "damp",
            "dirty",
            "dry",
            "fluffy",
            "freezing",
            "greasy",
            "hot",
            "icy",
            "loose",
            "melted",
            "prickly",
            "rough",
            "shaggy",
            "sharp",
            "slimy",
            "sticky",
            "tight",
            "uneven",
            "warm",
            "wet",
            #endregion

            #region Weight
            "cumbersome",
            "dense",
            "heavy",
            "light"
            #endregion
        };
    }

    public static class NounList
    {
        public static List<string> nouns = new List<string>
        {
            #region Animals
            "Cat",
            "Cattle",
            "Dog",
            "Donkey",
            "Goat",
            "Horse",
            "Pig",
            "Rabbit",
            "Albatross",
            "Alligator",
            "Alpaca",
            "Ant",
            "Ape",
            "Baboon",
            "Badger",
            "Bass",
            "Bat",
            "Bear",
            "Beaver",
            "Bedbug",
            "Bee",
            "Beetle",
            "Bird",
            "Bison",
            "Blackbird",
            "Boa",
            "Boar",
            "Bobcat",
            "Bug",
            "Butterfly",
            "Buzzard",
            "Camel",
            "Capybara",
            "Cardinal",
            "Caribou",
            "Carp",
            "Cat",
            "Caterpillar",
            "Catfish",
            "Cheetah",
            "Chicken",
            "Chimpanzee",
            "Chipmunk",
            "Clam",
            "Clownfish",
            "Cobra",
            "Cockroach",
            "Cod",
            "Condor",
            "Coral",
            "Cougar",
            "Cow",
            "Crab",
            "Crane",
            "Crawdad",
            "Crayfish",
            "Cricket",
            "Crocodile",
            "Crow",
            "Cuckoo",
            "Damselfly",
            "Deer",
            "Dingo",
            "Dinosaur",
            "Dog",
            "Dolphin",
            "Donkey",
            "Dove",
            "Dragonfly",
            "Dragon",
            "Duck",
            "Eagle",
            "Earthworm",
            "Eel",
            "Elephant",
            "Elk",
            "Emu",
            "Ermine",
            "Falcon",
            "Ferret",
            "Finch",
            "Firefly",
            "Fish",
            "Flamingo",
            "Flea",
            "Fly",
            "Fowl",
            "Fox",
            "Frog",
            "Gecko",
            "Gerbil",
            "Giraffe",
            "Goat",
            "Goldfish",
            "Goose",
            "Gopher",
            "Gorilla",
            "Grasshopper",
            "Gull",
            "Guppy",
            "Halibut",
            "Hamster",
            "Hare",
            "Hawk",
            "Hedgehog",
            "Heron",
            "Herring",
            "Hornet",
            "Horse",
            "Iguana",
            "Jackal",
            "Jaguar",
            "Jay",
            "Jellyfish",
            "Kangaroo",
            "Kiwi",
            "Koala",
            "Krill",
            "Ladybug",
            "Lemming",
            "Lemur",
            "Leopard",
            "Leopon",
            "Limpet",
            "Lion",
            "Lizard",
            "Llama",
            "Lobster",
            "Locust",
            "Loon",
            "Louse",
            "Lungfish",
            "Lynx",
            "Mammal",
            "Manatee",
            "Marlin",
            "Mastodon",
            "Meerkat",
            "Mink",
            "Minnow",
            "Mite",
            "Mockingbird",
            "Mole",
            "Mollusk",
            "Muskrat",
            "Mongoose",
            "Moose",
            "Mosquito",
            "Moth",
            "Mule",
            "Narwhal",
            "Newt",
            "Ocelot",
            "Octopus",
            "Orangutan",
            "Orca",
            "Ostrich",
            "Otter",
            "Owl",
            "Ox",
            "Panda",
            "Panther",
            "Parakeet",
            "Parrot",
            "Peacock",
            "Pelican",
            "Penguin",
            "Pheasant",
            "Pike",
            "Piranha",
            "Platypus",
            "Pony",
            "Porcupine",
            "Porpoise",
            "Prawn",
            "Mantis",
            "Primate",
            "Puffin",
            "Puma",
            "Python",
            "Quail",
            "Raccoon",
            "Rattlesnake",
            "Raven",
            "Reindeer",
            "Reptile",
            "Roadrunner",
            "Rodent",
            "Rook",
            "Rooster",
            "Salamander",
            "Scorpion",
            "Seahorse",
            "Shrew",
            "Shrimp",
            "Skunk",
            "Sloth",
            "Slug",
            "Smelt",
            "Snail",
            "Snake",
            "Snipe",
            "Leopard",
            "Sparrow",
            "Spider",
            "Monkey",
            "Squid",
            "Squirrel",
            "Starfish",
            "Stingray",
            "Stork",
            "Sturgeon",
            "Swallow",
            "Swan",
            "Tarantula",
            "Thrush",
            "Tick",
            "Tiger",
            "Shark",
            "Toad",
            "Tortoise",
            "Spider",
            "Frog",
            "Trout",
            "Tuna",
            "Turtle",
            "Bat",
            "Squid",
            "Viper",
            "Vole",
            "Vulture",
            "Wallaby",
            "Walrus",
            "Wasp",
            "Boa",
            "Weasel",
            "Whale",
            "Crane",
            "Wildcat",
            "Wolf",
            "Wolverine",
            "Wombat",
            "Woodpecker",
            "Worm",
            "Perch",
            "Zebra",
            "Alpaca",
            "Cat",
            "Cattle",
            "Chicken",
            "Dog",
            "Camel",
            "Canary",
            "Duck",
            "Goat",
            "Goose",
            "Pig",
            "Pigeon",
            "Rabbit",
            "Fox",
            "Turkey",
            "Donkey",
            "Mouse",
            "Rat",
            "Ferret",
            "Goldfish",
            "Guppy",
            "Horse",
            "Llama",
            "Dove",
            "Sheep",
            "Fish",
            "Finch",
            "Yak",
            "Buffalo",
            #endregion

            #region Food
            acorn
            alfalfa
            almond
            anchovy
            anise
            appetizer
            apple
            apricot
            artichoke
            asparagus
            aspicate
            avocado

            bacon
            bagel
            bamboo
            banana
            barbecue
            barley
            basil
            batter
            beancurd
            beans
            beef
            beet
            berry
            biscuit
            blackberry
            blueberry
            bran
            bread
            breakfast
            brisket
            broccoli
            brownie
            burrito
            butter

            cake
            candy
            carrot
            cashew
            celery
            cereal
            chard
            cheddar
            cheese
            cheesecake
            chef
            cherry
            chew
            chick peas
            chicken
            chili
            chips
            chives
            chocolate
            chopsticks
            chow
            chutney
            cilantro
            cinnamon
            citron
            citrus
            clam
            cloves
            cobbler
            coconut
            cod
            coffee
            coleslaw
            collard greens
            comestibles
            cook
            cookbook
            cookie
            corncornflakes
            cornmeal
            cottage cheese
            crabcrackers
            cranberry
            cream
            cream cheese
            crepe
            crisp
            crunch
            crust
            cucumber
            cuisine
            cupboard
            cupcake
            curds
            currants
            curry
            custard

            dairy
            dandelion
            dessert
            dinner
            dip
            dish
            doughnut
            dressing

            egg
            eggplant
            eentree

            feast
            fig
            fillet
            fire
            fish
            flan
            flour
            food
            fritter
            frosting
            fruit
            
            garlic
            gastronomy
            gelatin
            ginger
            ginger ale
            gingerbread
            glasses
            Gouda cheese
            grain
            granola
            grape
            grapefruit
            grated
            gravy
            green bean
            green tea
            greens
            grub
            guacamole
            guava
            gyro

            halibut
            ham
            hamburger
            hash
            hazelnut
            herbs
            honey
            honeydew
            horseradish
            hot
            hot dog
            hot sauce
            hummus
            hunger
            hungry

            ice
            ice cream
            ice cream cone
            iceberg lettuce
            iced tea
            icing

            jackfruit
            jam
            jelly
            jellybean
            jug
            juice
            junk

            kalekebabketchupkettlekettle cornkidney beanskitchenkiwiknifekohlrabikumquat

            ladlelamblardlasagnalegumeslemonlemonadelentilslettucelicoricelima beanslimeliverloaflobsterlollipoploquatloxlunchlunch boxlunchmeatlychee

            macaronimacaroonmain coursemaizemandarin orangemangomaple syrupmargarinemarionberrymarmalademarshmallowmashed potatoesmayonnaisemeatmeatballmeatloafmelonmenumeringuemicronutrientmilkmilkshakemilletmincemeatmineralsmintmintsmochimolassesmole saucemozzarellamuffinmugmunchmushroommusselsmustardmustard greensmutton


            napkinnectarnectarinenibblenoodlesnoshnourishnourishmentnutnutmegnutrientnutritionnutritious

            oatmealoatsoilokraoleooliveomeletomnivoreonionorangeorderoreganoovenoyster

            panpancakepapayaparsleyparsnippastapastrypatepattypattypan squashpeapea podpeachpeanutpeanut butterpearpecanpepperpepperonipersimmonpicklepicnicpiepilafpineapplepita breadpitcherpizzaplateplatterplumpoachedpomegranatepomelopoppopcornpopoverspopsicleporkpork chopspotpot roastpotatopreservespretzelprime ribproteinprovisionsprunepuddingpumpernickelpumpkinpunch

            quichequinoa

            radishraisinraspberryrationsraviolireciperefreshmentsrefrigeratorrelishrestaurantrhubarbribsriceroastrollrolling pinromainerosemaryrye

            saffronsagesaladsalamisalmonsalsasaltsandwichsaucesauerkrautsausagesavoryscallopsscrambledseaweedseedssesame seedshallotssherbetshish kebabshrimpslawslicesmokedsnacksodasoda breadsolesorbetsorghumsorrelsoupsoursour creamsoysoy saucesoybeansspaghettispareribsspatulaspicesspicyspinachsplit peasspoonsporksprinklessproutsspudssquashsquidsteakstewstir-frystomachstovestrawstrawberrystring beanstringystrudelsub sandwichsubmarine sandwichsuccotashsuetsugarsummer squashsundaesunflowersuppersushisustenancesweetsweet potatoSwiss chardsyrup

            tacotake-outtamaletangerinetapiocatarotarragontartteateapotteriyakithymetoasttoastertoffeetofutomatillotomatotortetortillatubertunaturkeyturmericturnip

            vanillavealvegetablevenisonvinegarvitamin

            waferwafflewalnutwasabiwaterwater chestnutwatercresswatermelonwheatwheywhipped creamwok

            yamyeastyogurtyolk

            zucchini

#endregion
        };
    }
}
