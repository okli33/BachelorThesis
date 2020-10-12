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
    
       cy.get('#header-tabs > #admin-menu > .dropdown-menu > .dropdown-item:nth-child(8) > span').click()
    
       cy.visit('http://localhost:9000/h2-console/login.jsp?jsessionid=e2037872ef67e160acf33564edda0ff6')
    
    })
   
   })
   