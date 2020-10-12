describe('test_name', function() {

    it('what_it_does', function() {
   
       cy.visit('http://localhost:9000/')
    
       cy.viewport(1848, 947)
    
       cy.visit('http://localhost:9000/')
    
       cy.get('.collapse > #header-tabs > #account-menu > .d-flex > span').click()
    
       cy.get('#header-tabs > #account-menu > .dropdown-menu > #login-item > span').click()
    
       cy.get('.modal-body > .row > .col-md-12 > .form-group > #username').type('user')
    
       cy.get('.modal-body > .row > .col-md-12 > .form-group > #password').click()
    
       cy.get('.modal-body > .row > .col-md-12 > .form-group > #password').type('user')
    
       cy.get('.modal-content > .av-valid > .modal-footer > .btn-primary > span').click()
    
       cy.get('.collapse > #header-tabs > #account-menu > .d-flex > span').click()
    
       cy.get('#header-tabs > #account-menu > .dropdown-menu > .dropdown-item:nth-child(2) > span').click()
    
       cy.get('.justify-content-center > .col-md-8 > #password-form > .form-group > #currentPassword').click()
    
       cy.get('.justify-content-center > .col-md-8 > #password-form > .form-group > #currentPassword').type('user')
    
       cy.get('.justify-content-center > .col-md-8 > #password-form > .form-group > #newPassword').click()
    
       cy.get('.justify-content-center > .col-md-8 > #password-form > .form-group > #newPassword').type('user1')
    
       cy.get('.justify-content-center > .col-md-8 > #password-form > .form-group > #confirmPassword').click()
    
       cy.get('.justify-content-center > .col-md-8 > #password-form > .form-group > #confirmPassword').type('user1')
    
       cy.get('.justify-content-center > .col-md-8 > #password-form > .btn > span').click()
    
       cy.visit('http://localhost:9000/account/password')
    
       cy.get('.justify-content-center > .col-md-8 > #password-form > .form-group > #currentPassword').click()
    
       cy.get('.justify-content-center > .col-md-8 > #password-form > .form-group > #currentPassword').type('user1')
    
       cy.get('.justify-content-center > .col-md-8 > #password-form > .form-group > #newPassword').click()
    
       cy.get('.justify-content-center > .col-md-8 > #password-form > .form-group > #newPassword').type('user')
    
       cy.get('.justify-content-center > .col-md-8 > #password-form > .form-group > #confirmPassword').click()
    
       cy.get('.justify-content-center > .col-md-8 > #password-form > .form-group > #confirmPassword').type('user')
    
       cy.get('.justify-content-center > .col-md-8 > #password-form > .btn > span').click()
    
    })
   
   })
   