function aggregateTable(lines) {
    let sum = 0, list = [];
    for (let line of lines) {
        let townData = line.split('|'),
            townName = townData[1].trim(),
            income = Number(townData[2].trim());

        sum += income;
        list.push(townName);
    }

    console.log(list.join(', ') + '\n' + sum);
}