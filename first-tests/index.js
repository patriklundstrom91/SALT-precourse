const greeting = greet('Marcus');
if (greeting === 'Welcome to SALT, Marcus') {
    console.log('IT WORKS');
} else {
    console.log('IT FAILS');
}

function greet(namePassedIn) {
    return 'Welcome to SALT, ' + namePassedIn;
}

module.exports.greet = greet;