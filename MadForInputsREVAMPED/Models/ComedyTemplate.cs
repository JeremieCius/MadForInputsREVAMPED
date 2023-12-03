namespace MadForInputsREVAMPED.Models
{
    public class ComedyTemplate
    {
        public string NameOne { get; set; }

        public string NameTwo { get; set; }

        public string NameThree { get; set; }

        public string NameFour { get; set; }

        public string LocationOne { get; set; }

        public string LocationTwo { get; set; }

        public string LocationThree { get; set; }

        public string LocationFour { get; set; }

        public string AdjectiveOne { get; set; }

        public string AdjectiveTwo { get; set; }

        public string AdjectiveThree { get; set; }

        public string AdjectiveFour { get; set; }

        public string VerbOne { get; set; }

        public string VerbTwo { get; set; }

        public string VerbThree { get; set; }

        public string VerbFour { get; set; }

        public string AdverbOne { get; set; }

        public string AdverbTwo { get; set; }

        public string AnythingOne { get; set; }

        public string AnythingTwo { get; set;}

        public string AnythingThree { get; set;}

        public string AnythingFour { get; set;}

        public ComedyTemplate()
        {

        }

        public ComedyTemplate(string nameOne, string nameTwo, string nameThree, string nameFour, string locationOne, string locationTwo, string locationThree, string adjectiveOne, string adjectiveTwo, string adjectiveThree, string adjectiveFour, string verbOne, string verbTwo, string verbThree, string verbFour, string adverbOne, string adverbTwo, string anythingOne, string anythingTwo, string anythingThree, string anythingFour, string locationFour)
        {
            NameOne = nameOne;
            NameTwo = nameTwo;
            NameThree = nameThree;
            NameFour = nameFour;
            LocationOne = locationOne;
            LocationTwo = locationTwo;
            LocationThree = locationThree;
            AdjectiveOne = adjectiveOne;
            AdjectiveTwo = adjectiveTwo;
            AdjectiveThree = adjectiveThree;
            AdjectiveFour = adjectiveFour;
            VerbOne = verbOne;
            VerbTwo = verbTwo;
            VerbThree = verbThree;
            VerbFour = verbFour;
            AdverbOne = adverbOne;
            AdverbTwo = adverbTwo;
            AnythingOne = anythingOne;
            AnythingTwo = anythingTwo;
            AnythingThree = anythingThree;
            AnythingFour = anythingFour;
            LocationFour = locationFour;
        }

        public override string ToString()
        {
            Random prompt = new Random();
            string story = "";

            switch (prompt.Next(3, 1))
            {
                case 1:
                    story = $@"
                    In the quaint town of {LocationOne}, where the very air seemed to shimmer with the promise of mirth and amusement, a fantastical journey unfurled, starring a cast of characters whose comedic escapades would resonate through the annals of laughter. At the forefront of this uproarious adventure stood the incomparable quartet—{NameOne}, the master of merriment; {NameTwo}, the virtuoso of hilarity; {NameThree}, the maestro of wit; and {NameFour}, the jester extraordinaire.

Their laugh-inducing odyssey commenced amid the vibrant carnival festivities of {LocationTwo}, where the attractions rivaled the quartet's own eccentricities. It all began when {NameOne}, renowned for their {AdjectiveOne} sense of humor, concocted a plan to lead the group in a zany dance-off. The streets reverberated with the sound of uproarious laughter as {NameTwo} showcased their {AdjectiveTwo} dance moves, leaving onlookers in stitches.

Buoyed by the infectious laughter that surrounded them, the quartet decided to extend their comedic conquest to {LocationThree}, a town synonymous with quirky talent shows. Here, {NameThree}, armed with their {AdjectiveThree} wit, took center stage. Their comedy routine involved {VerbOne} a rubber chicken, {AdverbOne} juggling, and incorporating {AnythingOne} as an unexpected and uproarious prop. The crowd erupted in thunderous applause, and the quartet quickly became the talk of the town.

Undeterred by the wild success of their talents, the group spontaneously embarked on a riotous road trip to {LocationFour}, a place celebrated for its offbeat charm and unconventional delights. The journey itself became a series of comical misadventures, from {AdverbTwo} navigating a roundabout to {VerbTwo} with an overenthusiastic GPS that seemed to have developed a penchant for outrageous detours.

Upon reaching {LocationFour}, the quartet stumbled upon a peculiar cafe where the menu featured {AnythingTwo}-flavored coffee and {AnythingThree}-shaped pancakes. Here, {NameFour}, known for their {AdjectiveFour} sense of culinary adventure, insisted on ordering the quirkiest items on the menu, leading to a symphony of laughter as they attempted to {VerbThree} with spaghetti using chopsticks.

As the comedic odyssey continued, the quartet discovered a {AnythingFour}-themed amusement park where the roller coasters defied the laws of gravity, and the cotton candy glowed in the dark. In a fit of inspired lunacy, {NameOne} persuaded the group to partake in a contest involving {VerbFour} with giant inflatable hammers, resulting in a spectacle that left both participants and spectators doubled over with laughter.

The sun eventually set on their uproarious adventure, casting long shadows of joy and mirth across the charming town of {LocationOne}. The echoes of their laughter lingered in the air, and the townsfolk, initially perplexed by the antics of the quartet, soon found themselves infected by the contagious spirit of joy. The legacy of their comedic capers would be retold for generations, a testament to the power of laughter and the boundless possibilities that unfold when a quartet of {AdjectiveTwo}, {AdjectiveThree}, {AdjectiveFour}, and {AdjectiveOne} individuals decide to embrace the absurdity of life.

And so, in the heart of {LocationOne}, the quartet, with their {AnythingFour}-induced glee, became local legends, forever enshrined in the town's history as the troupe that turned everyday life into an extraordinary comedy. Their legacy became a source of inspiration for comedians, storytellers, and anyone seeking to add a touch of whimsy to their lives, as the quartet's laughter echoed through the ages, a timeless reminder of the enduring power of joy and camaraderie that transcends the constraints of time itself. As the quartet's legendary reputation spread far and wide, they decided to organize an uproarious charity event in the heart of {LocationOne}. The event, aptly named ""The Laugh-a-Palooza,"" aimed to raise funds for a local community project while spreading joy through their signature brand of comedy.

The festivities kicked off in the town square, transformed into a carnival of hilarity. Booths featured {AdjectiveFour} games like {VerbThree} with rubber chickens, {AdverbTwo} navigating a maze of laughter, and a dunk tank where {NameFour} valiantly volunteered to be the target, promising to tell even funnier jokes with each splash.

The laughter-filled atmosphere drew the attention of local businesses, and soon, sponsors clamored to support the event. The town's theater graciously offered its stage for a star-studded comedy show, featuring the quartet alongside surprise celebrity guests. The performance showcased {NameOne}'s {AdjectiveTwo} improv skills, {NameTwo}'s slapstick antics, {NameThree}'s witty one-liners, and {NameFour}'s ability to turn even the most mundane jokes into comedic gold.

The Laugh-a-Palooza became the talk of the town and beyond, drawing attendees from neighboring areas who eagerly joined in the laughter. The event's success exceeded expectations, raising an astonishing amount for the community project while leaving a lasting impact on everyone present.

Encouraged by the positive response, the quartet decided to establish an annual tradition, turning The Laugh-a-Palooza into a cherished event that brought people together from far and wide. With each passing year, the festivities grew, incorporating even more outrageous games, sidesplitting performances, and unexpected surprises.

As the quartet continued to spread laughter and joy, their legacy transcended the borders of {LocationOne}. The town, once known for its serene charm, now stood as a beacon of hilarity, attracting visitors seeking the unique blend of comedy and community.

And so, in the heart of {LocationOne}, the quartet became not only local legends but also ambassadors of laughter. Their commitment to bringing joy to the world left an indelible mark on the town, transforming it into a haven where laughter wasn't just a fleeting moment but a way of life, echoing through the streets for generations to come.
";
                    break;

                case 2:
                    story = $@"
                    In the vibrant city of {LocationOne}, where the rhythm of urban life harmonized with the melody of whimsy, an extraordinary tale unfolded featuring an unlikely protagonist — {NameOne}, the audacious {AnythingTwo}. Nestled in a cozy apartment, {NameOne} was not your typical individual; rather, they were a charismatic and outspoken than other {AnythingTwo}s.

The comedic odyssey of {NameOne} began within the walls of their urban sanctuary, where they shared the laughter-filled space with their equally vivacious human companion, {NameTwo}. Together, this dynamic duo embarked on a series of uproarious escapades that blurred the lines between reality and the fantastical world of talking teddy bears.

Their inaugural adventure took them to the renowned {LocationTwo} comedy club, where {NameTwo} decided to unveil {NameOne}'s unique talents to the world. With {NameOne} serving as the ultimate comedic maestro, their routine involved {VerbOne} with a rubber chicken, {AdverbOne} impersonations of famous comedians, and incorporating everyday objects as unexpected punchlines. The crowd erupted in raucous laughter, and {NameTwo} instantly became the talk of the town.

Encouraged by their success, the duo delved into the realm of online comedy, creating a viral sensation with their whimsical sketches. From {VerbTwo} with household items to {VerbThree} with {AdjectiveThree} results, their videos became an online sensation, attracting a legion of fans who couldn't get enough of their unpredictable brand of humor.

Their comedic prowess caught the eye of a local television station, catapulting {NameOne} and {NameTwo} into the spotlight. Soon, they found themselves hosting their own late-night talk show, complete with celebrity interviews, outlandish games, and {AdjectiveFour} segments where {NameOne} served as the unfiltered voice of the audience. The show's success soared, transforming {NameOne} and {NameTwo} into local celebrities.

Despite their newfound fame, the duo remained grounded. They decided to organize an annual {AdjectiveOne} block party in the heart of {LocationThree}, inviting neighbors, fans, and a surprise appearance from a giant, inflatable {AnythingThree}. The block party featured oversized games, a hilarious stand-up comedy competition, and {AdverbTwo} navigating a maze of laughter. The event became a highlight on the city's calendar, attracting sponsorships, celebrities, and laughter enthusiasts from all corners of the city.

As the years passed, the block party evolved into a citywide celebration of laughter and camaraderie. Local businesses eagerly sponsored the event, and celebrities lined up to participate. The city of {LocationOne} transformed into a beacon of hilarity, with {NameOne} and {NameTwo} at the helm, orchestrating an annual extravaganza that brought joy to the hearts of all who attended.

And so, in the heart of the city, {NameOne} and {NameTwo}, with their {AnythingFour}-induced glee, became legendary figures, leaving an indelible mark on the urban landscape. Their whimsical escapades proved that, in a world that often takes itself too seriously, the antics of a talking teddy bear and their human companion could turn the ordinary into the extraordinary, one laugh at a time.
";
                    break;
                
                case 3:
                    story = $@"
                    The tale commenced in the modest apartment shared by {NameOne} and {NameTwo}, where their lack of common sense and penchant for hilarity formed the cornerstone of their daily lives. One day, inspired by a misread map, the duo decided to embark on a cross-country road trip to {LocationTwo}, believing it to be the ultimate destination for finding the rarest of {AnythingOne}.

Their journey, filled with nonsensical detours and comically misguided decisions, took them through a series of laugh-inducing scenarios. From attempting to {VerbOne} with a broken-down {AdjectiveOne} car to mistaking a roadside attraction for a {AnythingTwo}-themed amusement park, their antics became the stuff of local legend.

Undeterred by their constant mishaps, {NameOne} and {NameTwo} pressed on, eventually stumbling upon a peculiar {LocationThree} diner renowned for its {AdjectiveTwo} menu. Here, they decided to take on the {AdjectiveThree} food challenge, involving {AnythingThree}-flavored pancakes and a {AdverbOne} spicy hot sauce that left them gasping for breath.

Their journey reached new heights of absurdity when they encountered a traveling circus in {LocationFour}. Mistakenly assuming it to be a secret society of {AdjectiveFour} experts, {NameOne} and {NameTwo} volunteered to showcase their unique talents. The resulting performance, involving {VerbTwo} with oversized clown shoes and {VerbThree} through flaming hoops, left the audience in stitches and the circus performers bewildered.

As their adventure continued, the duo's reputation for comedic chaos spread far and wide. Local businesses embraced their eccentricity, and soon, {NameOne} and {NameTwo} found themselves unwittingly becoming the faces of a quirky advertising campaign for {AnythingFour}-flavored snacks.

In a surprising turn of events, their journey led them back to the heart of {LocationOne}, where the townsfolk, initially perplexed by their antics, welcomed them with open arms. The duo's infectious laughter became a source of joy, transforming the once-ordinary town into a hub of hilarity.

And so, in the heart of {LocationOne}, {NameOne} and {NameTwo} became local legends, forever etching their mark on the town's history. Their escapades, marked by absurdity and a lack of common sense, proved that sometimes, in the pursuit of laughter, the journey itself is the destination.
";
                    break;
            }
        return story;
        }
    }
}
