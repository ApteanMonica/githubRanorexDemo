// ***********************************************
// This example commands.js shows you how to
// create various custom commands and overwrite
// existing commands.
//
// For more comprehensive examples of custom
// commands please read more here:
// https://on.cypress.io/custom-commands
// ***********************************************
//
//
// -- This is a parent command --
// Cypress.Commands.add('login', (email, password) => { ... })
//
//
// -- This is a child command --
// Cypress.Commands.add('drag', { prevSubject: 'element'}, (subject, options) => { ... })
//
//
// -- This is a dual command --
// Cypress.Commands.add('dismiss', { prevSubject: 'optional'}, (subject, options) => { ... })
//
//
// -- This will overwrite an existing command --
// Cypress.Commands.overwrite('visit', (originalFn, url, options) => { ... })

/// <referance types="Cypress"/>

///<referance types="Cypress-xpath"/>
Cypress.Commands.add('login', (Username,Password,DBName,Firm) => {
    var BaseURL = 'localhost:8080//api-et-system-v2-'
    cy.request({
        method: "POST",
        url: `${BaseURL}AuthenticationService.svc/json/context`,
        Headers: {},
        body: {
            "Username": Username,
            "Password": Password,
            "DBName": DBName,
            "Firm": Firm
        }
    }).then(async (response) => {
        return response;
    })
})