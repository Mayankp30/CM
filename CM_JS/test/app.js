String.prototype.startsWith = function (matchString) {
    //if exact match return true
    if (this == matchString)
        return true;
    
    var matchString = '^' + matchString + '[\x20-\x7E]+$';
        
    var regex = new RegExp(matchString);
    return !!this.match(regex);
};

String.prototype.endsWith = function (matchstring) {
    return reverse(this).startsWith(reverse(matchstring));
}

function reverse(s) {
    return s.toString().split("").reverse().join("");
    console.log('from app . js 2');
}
