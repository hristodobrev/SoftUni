function distanceBetweenPoints([x1, y1, x2, y2]) {
    [x1, y1, x2, y2] = [x1, y1, x2, y2].map(Number);

    var distance = Math.sqrt(
        (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 -y2)
    );

    return distance;
}