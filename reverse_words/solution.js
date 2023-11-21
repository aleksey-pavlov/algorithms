let str = "very easy task";
let word = "";
let res = "";

for ( let i = str.length-1; i >= 0; i-- ) {
    
    if ( str[i] != " " ) {
        word += str[i];
    }

    if ( str[i] == " " || i == 0 ) {
        res = `${word} ${res}`;
        word = "";
    }
}

console.log( res );