describe('test_name', function() {

    it('what_it_does', function() {
   
       cy.visit('http://localhost:9000/')
    
       cy.viewport(1848, 947)
    
       cy.visit('http://localhost:9000/')
    
       cy.get('.collapse > #header-tabs > #account-menu > .d-flex > span').click()
    
       cy.get('#header-tabs > #account-menu > .dropdown-menu > #login-item > span').click()
    
       cy.get('.modal-body > .row > .col-md-12 > .form-group > #username').type('user')
    
       cy.get('.modal-body > .row > .col-md-12 > .form-group > #password').type('user')
    
       cy.get('#login-page > .modal-content > .av-valid > .modal-footer > .btn-primary').click()
    
       cy.get('.collapse > #header-tabs > #account-menu > .d-flex > span').click()
    
       cy.get('#header-tabs > #account-menu > .dropdown-menu > .dropdown-item:nth-child(1) > span').click()
    
       cy.get('.justify-content-center > .col-md-8 > #settings-form > .form-group > #lastName').click()
    
       cy.get('.justify-content-center > .col-md-8 > #settings-form > .form-group > #lastName').type('User1')
    
       cy.get('div > .justify-content-center > .col-md-8 > #settings-form > .btn').click()
    
       cy.visit('http://localhost:9000/account/settings')
    
       cy.get('.justify-content-center > .col-md-8 > #settings-form > .form-group > #lastName').click()
    
       cy.get('.justify-content-center > .col-md-8 > #settings-form > .form-group > #lastName').type('user')
    
       cy.get('div > .justify-content-center > .col-md-8 > #settings-form > .btn').click()
    
    })
   
   })
   