const contextMenuButtons = document.getElementsByClassName('context-menu-button');
const contextMenu = document.querySelector('#context-menu-display');

function displayAtMousePointer(event) {
    'use strict';

    let xCoord = event.clientX;
    let yCoord = event.clientY;

    contextMenu.style.top = `${yCoord}px`;
    contextMenu.style.left = `${xCoord}px`;
}

function showContextMenu() {
    'use strict';

    if (contextMenu.classList.contains('dont-display')) {
        contextMenu.classList.remove('dont-display');
    }
    else {
        contextMenu.classList.add('dont-display')
    }
};

function getCustomerId(row) {
    const rowElements = row.children;

    for (const element of rowElements) {
        if (element.classList.contains('customer-id-grabber')) {
            setIdRoute(element.innerHTML);  
        }
    }
}

function setIdRoute(value) {
    const editCustomerAnchor = document.getElementById('route-to-edit');
    const viewPipelineAnchor = document.getElementById('route-to-pipeline');

    editCustomerAnchor.href = `./Edit/${value}`;
    viewPipelineAnchor.href = `./Quotes/${value}`;
}

for (const row of contextMenuButtons) {
    row.addEventListener('contextmenu', (ev) => {
        ev.preventDefault();
        getCustomerId(row);
        showContextMenu();
        displayAtMousePointer(ev);
        return false;
    })
}

document.addEventListener('click', () => {
    contextMenu.classList.add('dont-display');
})
