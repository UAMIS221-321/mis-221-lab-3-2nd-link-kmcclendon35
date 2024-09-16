//start main
string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommendation(stadium);
DisplayStadiumDetails(stadium, game);
//end main

//methods
static string GetEnjoymentLevel(){
    Console.Clear();
    System.Console.WriteLine("What is your preferred level of enjoyment?\n1.Boring\n2.Average\n3.Fun\n4.Epic");
    return Console.ReadLine().ToLower();
}

static string GetStadiumRecommendation(string enjoymentLevel){
    string stadium = "";
    if(enjoymentLevel== "boring" || enjoymentLevel == "1"){
        stadium =  "Neyland Stadium";
    }
    else if(enjoymentLevel == "average" || enjoymentLevel == "2"){
       stadium =  "Jordan-Hare Stadium";
    }
    else if(enjoymentLevel == "fun" || enjoymentLevel == "3"){
        stadium = "Tiger Stadium";
    }
    else if(enjoymentLevel == "epic" || enjoymentLevel == "4"){
        stadium =  "Bryant-Denny Stadium";
    } 
    else{
        stadium = "none";
        System.Console.WriteLine("Invalid input. Exiting the program, please try again");
    }
    return stadium;
}
static string GetGameRecommendation(string stadium){
    string game = "";
    if(stadium== "Neyland Stadium"){
        game =  "Kent State";
    }
    else if(stadium == "Jordan-Hare Stadium"){
       game =  "Kentucky";
    }
    else if(stadium == "Tiger Stadium"){
        game = "Alabama";
    }
    else if(stadium == "Bryant-Denny Stadium"){
        game =  "Auburn";
    } 
    return game;
}
static void DisplayStadiumDetails(string stadium, string game){
    if(stadium != "none"){
    System.Console.WriteLine($"You should attend a game at {stadium} against {game}");
    }
}