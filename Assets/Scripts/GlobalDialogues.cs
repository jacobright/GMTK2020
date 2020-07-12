using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalDialogues 
{
    // initiations at time 0
    public static string[] initiation_greeting = {
        "Good morning!",
        "Good morning.",
        "G'mornin.",
        "Hm",
        "...",
        "BACK OFF",
        "AAAAAAAAAAAAAAAAAAAAAA"
    };

    // initiations at time 1, 3, 4, 6, 7
    public static string[] initiation_desk_interact_1 = {
        "Hey! What's Up?",
        "Hello, did you have a question?",
        "Hm?",
        "Can I help you??",
        "Huh? Whaddya want?",
        "CAN'T A GUY JUST WORK IN PEACE?!",
        "$&$*&^*&#^(*&^%$(*@&^#)(%$&%(#*^@"
    };

    // initiations at time 1, 3, 4, 6, 7
    public static string[] initiation_desk_interact_2 = {
        "What's cookin' good lookin'?",
        "Hi, did you want to talk?",
        "Yo.",
        "Is there a problem?",
        "Eh? Didja say something?",
        "YOU WANNA TAKE THIS OUTSIDE, PAL?",
        "I will grind your BONES into FLOUR and bake it into BREAD."
    };
    
    // initiations at time 1, 3, 4, 6, 7
    public static string[] initiation_desk_interact_3 = {
        "Hey, hi howdy!",
        "Penny for your thoughts?",
        "Hey.",
        "Yes?",
        "What are you, stupid? I'm tryna work here.",
        "IS THIS SOME SORT OF GAME TO YOU?!",
        "ALRIGHT, " + System.Environment.UserName + ", THAT'S THE LAST ******** STRAW"
    };

    // initiations at time 2
    public static string[] initiation_desk_interact_lunch = {
        "I sure hope there's tacos in the caf' today!",
        "Oh boy, I'm ready for lunch!",
        "Hm...Gettin' kinda hungry...",
        "*stomach rumbling*",
        "Ughh...hungryyy",
        "I CAN'T FUNCTION ON NEGATIVE CALORIES",
        "I THIRST FOR BLOOD AND HUNGER FOR LUNCH"
    };

    // initiation at time 5 (IF GOTTEN LUNCH, LUNCHLINE set to FALSE)
    public static string[] initiation_desk_post_lunch_noline = {
        "Now that's  what I call a satisfying lunch!",
        "No lunch line today! Luck must've been on my side.",
        "Ah, lunch was pretty good.",
        "Hmph. I should've taken a longer lunch.",
        "It's only halfway through the day?",
        "THAT WAS ONLY LUNCH? DOES TIME NOT PASS HERE?",
        "I WILL FEED ALL YOUR FINGERS TO RABID SEAGULLS"
    };

    // initiation at time 5 (IF GOTTEN LUNCH, LUNCHLINE set to TRUE)
    public static string[] initiation_desk_post_lunch_line = {
        "Mm, what a nice lunch! Too bad the line was so long.",
        "Ah, lunch was decent. Shame about that line.",
        "Hmph. Crowded lunchroom again.",
        "Do these people only take their lunch when I do?",
        "Stupid crowded lunchline, stupid idiot coworkers...",
        "CAN'T THESE PEOPLE JUST PACK A SANDWICH OR SOMETHING",
        "I WILL HERD YOU ALL OFF A CLIFF LIKE LEMMINGS"
    };

    // initiation at time 5 (IF MISSED LUNCH)
    public static string[] initiation_desk_no_lunch = {
        "---",
        "Oh. I missed lunch hour. Oh well.",
        "Shoot, I didn't get to eat lunch. My stomach hurts..",
        "Ughhh, my stomach is not happy with me, but lunch is over.",
        "Huh? It's already past lunch? I didn't even eat!",
        "WHAT DO YOU MEAN I MISSED LUNCH? WHY DIDN'T YOU REMIND ME?",
        "SUFFER THE CONSEQUENCES OF MY HANGER"
    };

////////

    public static string[] initiation_coffee_interact_no_line = {
        "Free coffee is the best!",
        "Not bad for free coffee.",
        "Ow. Hot.",
        "This coffee machine is pretty filthy.",
        "Are these even coffee beans? Tastes like burnt walnuts.",
        "I DON'T EVEN LIKE COFFEE.",
        "YOU HAVE MERELY FUELED MY RAGE WITH THIS BEAN DRINK."
    };

    public static string[] initiation_coffee_interact_line = {
        "If we're all caffeinated, a lot of work can get done!",
        "It's nice to enjoy coffee with your team.",
        "Does everyone really need to drink coffee right now?",
        "Why does everyone have those stupid novelty mugs?",
        "Hurryuphurryphurryuphurryuphurryuphurryup",
        "JUST GRAB YOUR COFFEE AND LEAVE, IT'S NOT THAT HARD",
        "CHOKE ON YOUR COFFEES, YOU CORPORATE SWINE"
    };

    public static string[] initiation_bathroom_interact_no_line = {
        "Good! There was no line!",
        "It's nice when you don't have to wait.",
        "Huh? My bathroom break? Uh, I guess it was fine?",
        "Yes, I went to the bathroom. What of it?",
        "Do you just ask everyone how their trip to the bathroom was?",
        "WHY ARE YOU ASKING ME ABOUT THE BATHROOM YOU CREEP?",
        "I WILL FLUSH YOU ALL LIKE NEGLECTED GOLDFISH"
    };

    public static string[] initiation_bathroom_interact_line = {
        "When ya gotta go, ya gotta go!",
        "Pretty long line...",
        "Should've gone a different time...",
        "How many kids are y'all droppin' off at the pool?",
        "Did somebody flush themselves or something?",
        "I WILL empty my bladder on this floor, DON'T TEST ME",
        "REPENT, " + System.Environment.UserName + ", FOR YOUR RECKONING IS UPON YOU"
    };

    public static string[] initiation_watercooler_interact_no_line = {
        "Ah! Refreshing!",
        "Mhm, good break.",
        "Gotta stay hydrated, I guess.",
        "Good, there's nobody else here.",
        "The water here tastes like plastic.",
        "WHO IN THE WORLD ENJOYS LUKEWARM WATER",
        "I WILL REFILL THIS WATERCOOLER WITH YOUR TEARS"
    };

    public static string[] initiation_watercooler_interact_line = {
        "Ah, a line? No biggie, I can wait!",
        "Oops, I should've waited for the line to clear first.",
        "Does anyone here do anything besides standing around?",
        "What is this, a watering hole? Are you all wildebeests?", 
        "Filthy slobbering animals need to replenish their slobber supply.",
        "I AM DEHYDRATED",
        "DROWN IN YOUR PAPER CUPS YOU USELESS PAWNS"
    };

    public static string[] initiation_desk_interact_chat = {
        "Seems like someone's chatty today, haha!",
        "Ah man, office gossip huh? Can't say I'm interested.",
        "Does he think I'm listening? Because I'm not.",
        "Does this guy ever stop talking?",
        "Shutupshutupshutupshutupshutup",
        "Hold me back before I PUNCH SOME LARYNX.",
        "SILENCE IS GOLDEN BUT ETERNITY IS BLACK"
    };

    public static string[] initiation_desk_interact_phone = {
        "It just wouldn't be an office without phones ringing!",
        "I'm sure somebody will answer that.",
        "That's been ringing for a while now...",
        "Is anyone going to answer that?",
        "If someone doesn't pick up that phone, so help me-",
        "ALEXANDAR GRAHAM BELL IS ROLLING IN HIS GRAVE",
        "THE NEXT PLACE THIS PHONE RINGS WILL BE UP YOUR CABOOSE"
    };

///////////

    public static string[] response_lunch_before = {
        "Oh, lunch hasn't started yet!",
        "It's still too early for lunch.",
        "It's not even lunchtime. ",
        "Who eats lunch this early?",
        "Are you stupid or something? We just got here. ",
        "THE CAFE ISN'T EVEN OPEN YET YOU NOODLE-BRAINED TWIT.",
        "---"
    };

    public static string[] response_lunch_after = {
        "Oh, lunch already ended!",
        "Lunch ended a bit ago. ",
        "Lunch is over.",
        "You know, lunch stops after lunch hour.",
        "What kind of moron doesn't get that lunch ended?",
        "THE CAFE IS CLOSED NOW YOU PINHEAD.",
        "---"
    };

    public static string[] response_lunch_agree = {
        "Good idea!",
        "Sure, why not?",
        "Alright.",
        "Fine. I am hungry.",
        "It better not be crowded...",
        "I was going to go ANYWAY.",
        "---"
    };

    public static string[] response_lunch_disagree = {
        "---",
        "---",
        "Maybe not right now.",
        "I can make my own decisions, okay?",
        "Pfft, like I'm gonna graze with the other livestock.",
        "YOU'RE NOT MY MOTHER, you can't MAKE me eat lunch.",
        "---"
    };

    public static string[] response_already_ate = {
        "No thanks, I'm full!",
        "I just ate!",
        "No thank you, I already had lunch.",
        "You want me to take another lunch? No.",
        "If I could spend all day eating lunch, I would. I already ate.",
        "STOP ASKING ME TO LUNCH I ALREADY ATE",
        "---"
    };

    public static string[] response_bathroom_agree = {
        "Okay!",
        "Not a bad idea.",
        "Yeah, sure.",
        "If it gets me away from this desk, then sure.",
        "...I guess I will, weirdo.",
        "I'll go if it means you'll GET OFF MY BACK.",
        "---"
    };

    public static string[] response_bathroom_disagree = {
        "---",
        "---",
        "You can go by yourself, can't you?",
        "I don't need to go right now.",
        "I think I know when I need the bathroom, thank you.",
        "Are YOU my bladder? Do YOU know when I need to PEE?? NO!",
        "---"
    };

    public static string[] response_coffee_agree = {
        "Free energy boost? Count me in!",
        "Hm, yeah, I could go for some coffee.",
        "Oh. Yeah, sounds good.",
        "Hmph, I guess.",
        "This stupid coffee better improve this stupid day..",
        "FINE but it's not like it's gonna help!",
        "---"
    };

    public static string[] response_coffee_disagree = {
        "---",
        "---",
        "That's okay, I think I'll just keep working.",
        "Do I look tired? I don't need coffee. ",
        "You call that garbage coffee? Absolutely not.",
        "I REFUSE TO OIL THE CORPORATE MACHINE WITH BAD COFFEE",
        "---"
    };

    public static string[] response_water_agree = {
        "Alright!",
        "Sounds good to me.",
        "Okay.",
        "Sure.",
        "I was already planning on it.",
        "If it'll get you to SHUT UP.",
        "---"
    };

    public static string[] response_water_disagree = {
        "---",
        "---",
        "I'm not thirsty.",
        "I don't want to right now.",
        "No. Besides, the water here is warm and gross.",
        "Will WATERING me make me feel better?? I'M NOT A PLANT.",
        "---"
    };

    public static string[] response_insult = {
        "Haha..good one.",
        "Yeahh, real funny.",
        "Do you mind?",
        "Watch it, " + System.Environment.UserName + ".",
        "Why you little...",
        "LISTEN HERE, DIRTBAG. ",
        "ALL RIGHT " + System.Environment.UserName + "! YOU AND ME. PARKING LOT."
    };

    public static string[] response_nevermind = {
        "Oh, okay!",
        "Oh.",
        "Please don't waste my time.",
        "Please don't bother me without a good reason.",
        "Quit wasting my time.",
        "CLICK ON ME ONE MORE TIME, SEE WHAT HAPPENS",
        "IF YOU WON'T SPIT IT OUT, I'LL DRAG THE WORDS OUTTA YOU"
    };

    public static string[] response_compliment_positive = {
        "Aw, that's so sweet! Thank you!",
        "Thank you!",
        "Thanks.",
        "Thanks?",
        "Hmph.",
        "THANK YOU NOW LET ME WORK IN PEACE.",
        "---"
    };

    public static string[] response_compliment_negative = {
        "Thanks?",
        "Uh, okay.",
        "Do you want something from me?",
        "I don't like kiss-ups ",
        "Flattery will get you nowhere.",
        "I HATE BROWN-NOSING",
        "GET OFF YOUR HIGH-HORSE YOU CONDESCENDING SUNOVA-"
    };







    public static string[] input_insult_happy = {
        "Whaddya call a loser marshmallow? Gary.",
        "What's white, round, and stupid? Gary.",
        "Has anyone ever told you you look generic?",
        "Yo mama so ugly, you look like her!",
        "So are you always this co-dependent?",
        "Lemme guess: you're a business major?",
        "Vacation? With your salary? Good luck.",
        "Whatcha thinkin' about? Oh wait, you're not.",
        "You look like a generic-brand Tic Tac.",
        "So what's your excuse for being so squishy?",
        "Wow your nose job looks great.",
        "Oh sorry, I mistook you for someone competent.",
        "Hey look at me, I'm Gary: ^ v ^",
        "Hey Gary, I'm sorry you don't have friends.",
        "Did you not brush your teeth today?",
        "I hope Taco Tuesday gets replaced with tuna.",
        "Are you baseball? ‘Cause you’re slow and boring.",
        "Are you the sun? ‘Cause you hurt my eyes.",
        "Is the vacation for you or everyone else?",
        "Am I getting paid for this?",
        "Gary you’re the best! At being the WORST.",
        "HEY EVERYONE, GARY EATS GARBAGE",
        "Ya think nobody noticed that fart? They did",
        "JEEZ Gary what did you EAT?",
        "How do you spell nerd? G-A-R-Y."
    };

    public static string[] input_insult_angry = {
        "You're awfully fragile, aren't you?",
        "Crybaby.",
        "Wahh, is the baby cranky??",
        "Y'know, you complain a lot.",
        "Try calming down.",
        "Boohoo, I'm Gary, I'm a delicate flower!",
        "Are you always this much of a sourpuss or..?",
        "You should do yoga.",
        "Seriously, yoga is great for stress relief.",
        "If you did yoga, you'd be less angry.",
        "Maybe if you did yoga, you'd have friends.",
        "Hey look at me, I'm Gary: >:(",
        "You're like sour candy except nobody likes you.",
        "Do you use anger to mask your insecurities?",
        "Y'know I'm not certified for this, right?",
        "I bet I could beat you at arm wrestling.",
        "20 bucks says you have a dumb tattoo.",
        "Do you use anger to compensate for something?",
        "Must suck to have all your coworkers hate you.",
        "Are you just jealous your phone never rings?",
        "It's understandable that no one calls you",
        "You should smile more.",
        "You should play hockey. You can be the puck",
        "I bet you got picked last for kickball.",
        "Nice face, where'd ya get it? The Pixel Store?",
        "Maybe you're crabby 'cause you eat garbage",
        "How do you spell nerd? G-A-R-Y."
    };

    public static string[] input_compliment = {
        "Good job Gary!",
        "Stay focused Gary: remember your vacation!",
        "Keep up the pace!",
        "Lookin' good Gary!",
        "I know the office can be hectic, just do your best!",
        "I think your co-workers look up to you!",
        "You've gotta be due for a promotion soon!",
        "I'm proud of you, Gary.",
        "It's great you're working on improving yourself!",
        "If you're feeling overwhelmed, just talk to me!",
        "Breathe...count slowly to ten.",
        "Your work keeps this place going smoothly!",
        "Don't sweat the small stuff!",
        "Wow! You're really good at your job!",
        "I can tell you're gonna go far.",
        "You're like the Taco Tuesday of office workers!",
        "If you were a weekday, you’d be Friday!",
        "Are you mint gum? ‘Cause you’re so refreshing!",
        "Are you a marshmallow? Cause you’re so sweet!",
        "You earned this vacation!",
        "Gary? More like VERY cool guy!",
        "You can't spell 'greatly' without Gary!"
    };

}
