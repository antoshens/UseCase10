using System.Text.RegularExpressions;

// Testing scenarios
TestStringMatching();

static bool HasMatch(string input, int maxNumberOfChars)
{
    var regexExpression = @"^(?=.*[A-Z]){1,}(?=.*[a-z]){1}(?=.*\d{1})(?=.*[!""#$%&'()*+,\-./:;<=>?@\[\]^_`{|}~])[A-Za-z\d!""#$%&'()*+,\-./:;<=>?@\[\]^_`{|}~]{1," + maxNumberOfChars + "}$";
    var regex = new Regex(regexExpression);
    var isMatch = regex.IsMatch(input);

    return isMatch;
}

static void TestStringMatching()
{
    var result = false;
    string stringUnderTest;

    // Case 1: too short input
    stringUnderTest = "";
    Console.WriteLine($"Test of string: '{stringUnderTest}'. Result {(result ? "matched" : "not matched")}");
    result = HasMatch(stringUnderTest, 10);

    // Case 2: too long input
    stringUnderTest = "Toolong123String";
    Console.WriteLine($"Test of string: '{stringUnderTest}'. Result {(result ? "matched" : "not matched")}");
    result = HasMatch(stringUnderTest, 10);

    // Case 3: matching input length
    stringUnderTest = "10Digits!#";
    Console.WriteLine($"Test of string: '{stringUnderTest}'. Result {(result ? "matched" : "not matched")}");
    result = HasMatch(stringUnderTest, 10);

    // Case 4: missing uppercase
    stringUnderTest = "10digits!#";
    Console.WriteLine($"Test of string: '{stringUnderTest}'. Result {(result ? "matched" : "not matched")}");
    result = HasMatch(stringUnderTest, 10);

    // Case 5: missing lowercase
    stringUnderTest = "10DIGITS!#";
    Console.WriteLine($"Test of string: '{stringUnderTest}'. Result {(result ? "matched" : "not matched")}");
    result = HasMatch(stringUnderTest, 10);

    // Case 6: missing special character
    stringUnderTest = "10DIGITSSS";
    Console.WriteLine($"Test of string: '{stringUnderTest}'. Result {(result ? "matched" : "not matched")}");
    result = HasMatch(stringUnderTest, 10);

    // Case 7: missing digit
    stringUnderTest = "TenDigits!";
    Console.WriteLine($"Test of string: '{stringUnderTest}'. Result {(result ? "matched" : "not matched")}");
    result = HasMatch(stringUnderTest, 10);

    // Case 8: excess whitespace at the begining
    stringUnderTest = " TenDigits";
    Console.WriteLine($"Test of string: '{stringUnderTest}'. Result {(result ? "matched" : "not matched")}");
    result = HasMatch(stringUnderTest, 10);

    // Case 9: excess whitespace in the middle
    stringUnderTest = "Ten Digits";
    Console.WriteLine($"Test of string: '{stringUnderTest}'. Result {(result ? "matched" : "not matched")}");
    result = HasMatch(stringUnderTest, 10);

    // Case 10: mexcess whitespace at the end
    stringUnderTest = "TenDigits ";
    Console.WriteLine($"Test of string: '{stringUnderTest}'. Result {(result ? "matched" : "not matched")}");
    result = HasMatch(stringUnderTest, 10);
}
