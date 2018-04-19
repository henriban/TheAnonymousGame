
using System.Collections.Generic;
using UnityEngine;

public static class Data {

    private static PersonModel personModel1;
    private static PersonModel personModel2;
    private static PersonModel personModel3;
    private static PersonModel personModel4;

    internal static PersonModel PersonModel1 {
        get {
            return personModel1;
        }

        set {
            personModel1 = value;
        }
    }

    internal static PersonModel PersonModel2 {
        get {
            return personModel2;
        }

        set {
            personModel2 = value;
        }
    }

    internal static PersonModel PersonModel3 {
        get {
            return personModel3;
        }

        set {
            personModel3 = value;
        }
    }

    internal static PersonModel PersonModel4 {
        get {
            return personModel4;
        }

        set {
            personModel4 = value;
        }
    }

    private static List<Sprite> reciptsPlayer1;
    private static List<Sprite> reciptsPlayer2;
    private static List<string> variables;

    public static List<Sprite> ReciptsPlayer1 {
        get {
            return reciptsPlayer1;
        }

        set {
            reciptsPlayer1 = value;
        }
    }

    public static List<Sprite> ReciptsPlayer2 {
        get {
            return reciptsPlayer2;
        }

        set {
            reciptsPlayer2 = value;
        }
    }

    public static List<string> Variables {
        get {
            return variables;
        }

        set {
            variables = value;
        }
    }

    
}