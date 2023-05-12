function dragAndDrop(className) {

    interact(className).draggable({
        listeners: {
            start(event) {
                console.log(event.type, event.target)
            },
            move(event) {
                var target = event.target,
                    // keep the dragged position in the data-x/data-y attributes
                    x = (parseFloat(target.getAttribute('X')) || 0) + event.dx,
                    y = (parseFloat(target.getAttribute('Y')) || 0) + event.dy;
                
                event.target.style.transform =
                    `translate(${x}px, ${y}px)`;
                
                // update the posiion attributes
                target.setAttribute('X', x);
                target.setAttribute('Y', y);
                
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

function setDimesions(x,y){
    document.querySelector('.draggable').setAttribute('X',x);
    document.querySelector('.draggable').setAttribute('X',y);
}
