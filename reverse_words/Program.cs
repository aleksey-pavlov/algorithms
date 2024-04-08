var str = "very easy task";
var word = "";
var res = "";

for ( var i = str.Count()-1; i >= 0; i-- ) {
    
    if ( str[i] != ' ' ) {
        word += str[i];
    }

    if ( str[i] == ' ' || i == 0 ) {
        res = $"{word} {res}";
        word = "";
    }
}

/* Result: "yrev ysae ksat" */
Console.WriteLine( res );