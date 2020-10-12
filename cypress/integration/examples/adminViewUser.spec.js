describe('test_name', function() {

    it('what_it_does', function() {
   
       cy.viewport(1478, 759)
    
       cy.visit('http://localhost:9000/')
    
       cy.get('.collapse > #header-tabs > #account-menu > .d-flex > span').click()
    
       cy.get('#header-tabs > #account-menu > .dropdown-menu > #login-item > span').click()
    
       cy.get('.modal-body > .row > .col-md-12 > .form-group > #username').type('admin')
    
       cy.get('.modal-body > .row > .col-md-12 > .form-group > #password').click()
    
       cy.get('.modal-body > .row > .col-md-12 > .form-group > #password').type('admin')
    
       cy.get('.modal-content > .av-valid > .modal-footer > .btn-primary > span').click()
    
       cy.get('.collapse > #header-tabs > #admin-menu > .d-flex > span').click()
    
       cy.get('#header-tabs > #admin-menu > .dropdown-menu > .dropdown-item:nth-child(1) > span').click()
    
       cy.get('#admin > .text-right > .btn-group > .btn-info > .d-none > span').click()
    
       cy.get('div > div > .btn > .d-none > span').click()
    
    })
   
   })
   