function triangleOfStars([n]) {
    for (let i = 1; i <= n; i++)
        printStars(i);
    for (let i = n - 1; i >= 1; i--)
        printStars(i);

    function printStars(count) {
        console.log("*".repeat(count));
    }
}