const addCustomerButton = document.getElementById('add-customer-button');
const newCustomerForm = document.getElementById('new-customer-form');

function openPopOutForm() {
    'use strict';
    
    if (newCustomerForm.classList.contains('dont-display')) {
        newCustomerForm.classList.remove('dont-display');
    }
    else {
        newCustomerForm.classList.add('dont-display');
    }

};

addCustomerButton.addEventListener('click', () => {
    $("#new-customer-form").fadeIn("slow");
    openPopOutForm();
});