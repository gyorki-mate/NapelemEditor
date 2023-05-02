var snapObjects = [];
snapObjects = document.getElementsByClassName("grid-item");

function dragAndDrop(className) {
    const position = {x: 0, y: 0}

    interact(className).draggable({
        listeners: {
            start(event) {
                console.log(event.type, event.target)
            },
            move(event) {
                position.x += event.dx
                position.y += event.dy

                event.target.style.transform =
                    `translate(${position.x}px, ${position.y}px)`
            },
        }, modifiers: [
            interact.modifiers.restrictRect({
                restriction: '.main',
                endOnly: true
            }),
            interact.modifiers.snap({
                targets: [interact.createSnapGrid({
                    x: 50,
                    y: 50,
                })],
                relativePoints: [{x: 0, y: 0}]
            })]
    })  // snap to the startCoords
}

var gridTarget = interact.snappers.grid({
    // can be a pair of x and y, left and top,
    // right and bottom, or width, and height
    x: 50,
    y: 50,

    // optional
    range: 10,

    // optional
    offset: {x: 5, y: 10},

    // optional
    limits: {
        top: 0,
        left: 0,
        bottom: 500,
        height: 500
    }
})
