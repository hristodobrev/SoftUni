function sortArray(arr, sortType) {
    if(sortType.toLowerCase() === 'asc'){
        return arr.sort((a, b) => a - b);
    } else {
        return arr.sort((a, b) => b - a);
    }
}

console.log(sortArray([14, 7, 17, 6, 8, 100], 'desc'));