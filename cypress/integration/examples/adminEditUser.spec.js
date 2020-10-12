
   describe('test_name', function() {

      it('what_it_does', function() {
     
         cy.visit('http://localhost:9000/')
      
         cy.viewport(1848, 949)
      
         cy.visit('http://localhost:9000/')
      
         cy.get('.collapse > #header-tabs > #account-menu > .d-flex > span').click()
      
         cy.get('#header-tabs > #account-menu > .dropdown-menu > #login-item > span').click()
      
         cy.get('.modal-body > .row > .col-md-12 > .form-group > #username').type('admin')
      
         cy.get('.modal-body > .row > .col-md-12 > .form-group > #password').type('admin')
      
         cy.get('#login-page > .modal-content > .av-valid > .modal-footer > .btn-primary').click()
      
         cy.get('.collapse > #header-tabs > #admin-menu > .d-flex > span').click()
      
         cy.get('#header-tabs > #admin-menu > .dropdown-menu > .dropdown-item:nth-child(1) > span').click()
      
         cy.get('#user > .text-right > .btn-group > .btn-primary > .d-none > span').click()
      
         cy.get('.jh-card > .view-routes > div > div > .justify-content-center:nth-child(2)').click()
      
         cy.get('.col-md-8 > .av-valid > .form-group > .form-group > #lastName').type('user')
      
         cy.get('.justify-content-center > .col-md-8 > .av-valid > .btn-primary > span').click()
      
      })
     
     })
     