describe('test_name', function() {

    it('what_it_does', function() {
   
       cy.visit('http://localhost:9000/')
    
       cy.viewport(1848, 947)
    
       cy.visit('http://localhost:9000/')
    
       cy.get('.collapse > #header-tabs > #account-menu > .d-flex > span').click()
    
       cy.get('#header-tabs > #account-menu > .dropdown-menu > #login-item > span').click()
    
       cy.get('.modal-body > .row > .col-md-12 > .form-group > #username').type('admin')
    
       cy.get('.modal-body > .row > .col-md-12 > .form-group > #password').type('admin')
    
       cy.get('#login-page > .modal-content > .av-valid > .modal-footer > .btn-primary').click()
    
       cy.get('.collapse > #header-tabs > #admin-menu > .d-flex > span').click()
    
       cy.get('#header-tabs > #admin-menu > .dropdown-menu > .dropdown-item:nth-child(1) > span').click()
    
       cy.get('div > div > #user-management-page-heading > .btn > span').click()
    
       cy.get('.col-md-8 > .av-invalid > .form-group > .form-group > #login').click()
    
       cy.get('.col-md-8 > .av-invalid > .form-group > .form-group > #login').type('test1')
    
       cy.get('.col-md-8 > .av-invalid > .form-group > .form-group > #firstName').click()
    
       cy.get('.col-md-8 > .av-invalid > .form-group > .form-group > #firstName').type('test1')
    
       cy.get('.col-md-8 > .av-invalid > .form-group > .form-group > #lastName').click()
    
       cy.get('.col-md-8 > .av-invalid > .form-group > .form-group > #lastName').type('test1')
    
       cy.get('.col-md-8 > .av-invalid > .form-group > .form-group > #email').click()
    
       cy.get('.col-md-8 > .av-invalid > .form-group > .form-group > #email').type('test1@mail.com')
    
       cy.get('.justify-content-center > .col-md-8 > .av-valid > .form-group > #authorities').select('ROLE_USER')
    
       cy.get('.col-md-8 > .av-valid > .form-group > #authorities > option:nth-child(2)').click()
    
       cy.get('.justify-content-center > .col-md-8 > .av-valid > .btn-primary > span').click()
    
       cy.get('#test1 > .text-right > .btn-group > .btn-danger > .d-none > span').click()
    
       cy.get('.modal-dialog > .modal-content > .modal-footer > .btn-danger > span').click()
    
    })
   
   })
   