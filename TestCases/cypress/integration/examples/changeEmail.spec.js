describe('test_name', function() {

    it('what_it_does', function() {
   
       cy.visit('http://localhost:9000/')
    
       cy.viewport(1848, 947)
    
       cy.visit('http://localhost:9000/')
    
       cy.get('.collapse > #header-tabs > #account-menu > .d-flex > span').click()
    
       cy.get('#header-tabs > #account-menu > .dropdown-menu > #login-item > span').click()
    
       cy.get('.modal-body > .row > .col-md-12 > .form-group > #username').type('user')
    
       cy.get('.modal-body > .row > .col-md-12 > .form-group > #password').type('user')
    
       cy.get('.modal-content > .av-valid > .modal-footer > .btn-primary > span').click()
    
       cy.get('.collapse > #header-tabs > #account-menu > .d-flex > .svg-inline--fa').click()
    
       cy.get('#header-tabs > #account-menu > .dropdown-menu > .dropdown-item:nth-child(1) > span').click()
    
       cy.get('.justify-content-center > .col-md-8 > #settings-form > .form-group > #email').click()
    
       cy.get('.justify-content-center > .col-md-8 > #settings-form > .form-group > #email').type('usertest@mail.com')
    
       cy.get('div > .justify-content-center > .col-md-8 > #settings-form > .btn').click()
    
       cy.get('.justify-content-center > .col-md-8 > #settings-form > .form-group > #email').click()
    
       cy.visit('http://localhost:9000/account/settings')
    
       cy.get('.justify-content-center > .col-md-8 > #settings-form > .form-group > #email').click()
    
       cy.get('.justify-content-center > .col-md-8 > #settings-form > .form-group > #email').type('user@mail.com')
    
       cy.get('.justify-content-center > .col-md-8 > #settings-form > .btn > span').click()
    
    })
   
   })
   