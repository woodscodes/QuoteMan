const contextMenuButtons = document.getElementsByClassName('context-menu-button');
const contextMenu = document.querySelector('#context-menu-display');

function displayAtMousePointer(event) {
    'use strict';

    const xCoord = event.clientX;
    const yCoord = event.clientY;

    contextMenu.style.top = `${yCoord}px`;
    contextMenu.style.left = `${xCoord}px`;
}

function toggleContextMenu() {
    'use strict';

    if (contextMenu.classList.contains('dont-display')) {
        contextMenu.classList.remove('dont-display');
    }
    else {
        contextMenu.classList.add('dont-display')
    }
};

function setCustomerId(row) {
    'use strict';
    const rowElements = row.children;

    for (const element of rowElements) {
        if (element.classList.contains('customer-id-grabber')) {
            setIdRoute(element.innerHTML);  
        }
        if (element.classList.contains('customer-name-grabber')) {
            setNameOfCustomer(element.innerHTML);
        }
    }
}

function setIdRoute(value) {
    'use strict';
    const editCustomerAnchor = document.getElementById('route-to-edit');
    const viewPipelineAnchor = document.getElementById('route-to-pipeline');
    const deleteAnchor = document.getElementById('route-to-delete');

    editCustomerAnchor.href = `/Customers/Edit/${value}`;
    viewPipelineAnchor.href = `/Customers/Quotes/${value}`;
    deleteAnchor.href = `/Customers/Delete/${value}`;
}

function setNameOfCustomer (value) {
    'use strict'
    const customerNameArea = document.getElementById('name-of-customer');

    customerNameArea.innerHTML = value; 
}

for (const row of contextMenuButtons) {
    'use strict';
    row.addEventListener('contextmenu', (ev) => {
        ev.preventDefault();
        setCustomerId(row);        
        toggleContextMenu();
        displayAtMousePointer(ev);
        return false;
    })
}

document.addEventListener('click', () => {
    toggleContextMenu();
})
