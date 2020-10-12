describe('test_name', function() {

 it('what_it_does', function() {

    cy.visit('http://localhost:9000/')
 
    cy.viewport(1848, 947)
 
    cy.visit('http://localhost:9000/')
 
    cy.get('.collapse > #header-tabs > #account-menu > .d-flex > span').click()
 
    cy.get('#header-tabs > #account-menu > .dropdown-menu > .dropdown-item:nth-child(2) > span').click()
 
    cy.get('.justify-content-center > .col-md-8 > #register-form > .form-group > #username').click()
 
    cy.get('.justify-content-center > .col-md-8 > #register-form > .form-group > #username').type('user1')
 
    cy.get('.justify-content-center > .col-md-8 > #register-form > .form-group > #email').type('user1@mail.com')
 
    cy.get('.justify-content-center > .col-md-8 > #register-form > .form-group > #firstPassword').type('user1')
 
    cy.get('.justify-content-center > .col-md-8 > #register-form > .form-group > #secondPassword').type('user1')
 
    cy.get('.justify-content-center > .col-md-8 > #register-form > #register-submit > span').click()
 
 })

})
