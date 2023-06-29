using System.Text.RegularExpressions;

static bool HasMatch(string input, int maxNumberOfChars)
{
    var regexExpression = @"^(?=.*[A-Z]){1,}(?=.*[a-z]){1}(?=.*\d{1})(?=.*[!""#$%&'()*+,\-./:;<=>?@\[\]^_`{|}~])[A-Za-z\d!""#$%&'()*+,\-./:;<=>?@\[\]^_`{|}~]{1," + maxNumberOfChars + "}$";
    var regex = new Regex(regexExpression);
    var isMatch = regex.IsMatch(input);

    return isMatch;
}
