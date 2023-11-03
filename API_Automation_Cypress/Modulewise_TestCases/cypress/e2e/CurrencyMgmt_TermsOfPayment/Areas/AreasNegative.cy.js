describe("GetAreaByAreaID", () => {

    var context = '';
    var context2 = '';
    var AreaBaseURL = 'localhost:8080//api-rw-fi-v1-'

    it("prerequisites", () => {

        cy.login('rs', 'rsc', 'rs2', '100').then((res) => {
            context = res.body.Context;
        })
    })

    //To generate context for user 200 who dont have permission to access the get areas

    it("Generate Context 2", () => {

        cy.login('rs', 'rsc', 'rs2', '200').then((res) => {
            context2 = res.body.Context;
        })
    })

    //This testcase is to verify if the user not having permission to get all Area, can not get all Area
    it("Verify if the user not having permission to get all Area, can not get all Area", () => {


        cy.request({
            method: "GET",
            url: `${AreaBaseURL}AreaService.svc/json/Area/AreasByCompany?context=${context2}`,

        }).then((response) => {

            //assertions
            assert.equal(response.body.Messages[0]["Id"], "rssoft.bfw.common.AccessDeniedError")
            //Access denied - To access this resource, you need the following right: API-RW-FI-AREASERVICE / *!
            assert.equal(response.body.Messages[0]["Text"], "Access denied - To access this resource, you need the following right: API-RW-FI-AREASERVICE / *!")

            expect(response.status).to.eq(200)



        })
    });

    //This testcase is to verify the user is not able to get all Area with an invalid context
    it("Verify the user is not able to get all Area with an invalid context", () => {


            cy.request({
            method: "GET",
            url: `${AreaBaseURL}AreaService.svc/json/Area/AreasByCompany?context=123456789`,
            
        }).then((response) => {

            //assertions
            assert.equal(response.body.Messages[0]["Id"], "rssoft.common.rs2.authentication.InvalidContextValueError")
            //"The specified login context (123456789) is invalid"
            assert.equal(response.body.Messages[0]["Text"], "Der angegebene Anmelde-Context (123456789) ist ungültig")

            expect(response.status).to.eq(200)



        })
    });

        //This testcase is to verify the user is unable to get a single value with invalid ref_code
it("Verify the user is unable to get a single value with invalid ref_code", () => {


    var AreaID = ["Z"]
    cy.request({
        method: "GET",
        url: `${AreaBaseURL}AreaService.svc/json/Area/${AreaID}/?context=${context}`,
        
    }).then((response) => {

         //assertions
         assert.equal(response.body.Messages[0]["Id"], "rssoft.common.message.DataNotFoundError")
         //"No Area could be found! "
         assert.equal(response.body.Messages[0]["Text"], "No Area could be found! ")

         expect(response.status).to.eq(200)



    })
});

    //This testcase is to verify if the user not having permission to get an Area, can not get an area
    it("Verify if the user not having permission to get an Area, can not get an area", () => {


        var AreaID = ["3"]
        cy.request({
            method: "GET",
            url: `${AreaBaseURL}AreaService.svc/json/Area/${AreaID}/?context=${context2}`,
           
        }).then((response) => {

             //assertions
             assert.equal(response.body.Messages[0]["Id"], "rssoft.bfw.common.AccessDeniedError")
             //Access denied - To access this resource, you need the following right: API-RW-FI-AREASERVICE / *!
             assert.equal(response.body.Messages[0]["Text"], "Access denied - To access this resource, you need the following right: API-RW-FI-AREASERVICE / *!")
 
             expect(response.status).to.eq(200)
 

        })
    });

    //This testcase is to verify the user is not able to get area with an invalid context
    it("Verify the user is not able to get area with an invalid context", () => {


        var AreaID = ["3"]
        cy.request({
            method: "GET",
            url: `${AreaBaseURL}AreaService.svc/json/Area/${AreaID}/?context=123456789`,
            
        }).then((response) => {

             //assertions
            assert.equal(response.body.Messages[0]["Id"], "rssoft.common.rs2.authentication.InvalidContextValueError")
            //"The specified login context (123456789) is invalid"
            assert.equal(response.body.Messages[0]["Text"], "Der angegebene Anmelde-Context (123456789) ist ungültig")

            expect(response.status).to.eq(200)
 

        })
    });

   
    //This testcase is to verify if the user not having permission to get  area using filter, can not get area using filter
    it("Verify if the user not having permission to get  area using filter, can not get area using filter", () => {


        
        cy.request({
            method: "Post",
            url: `${AreaBaseURL}AreaService.svc/json/Area/AreasByFilterContainer?context=${context2}`,
           
            body: {
                
                
                "Filter" : [
                    {
                        "FieldName" : "AreaId",
                        "Operator" : "LessOrEqual",
                        "Values" : [
                            "3"
                        ]
                    },
                    {
                        "FieldName" : "StockAccountControlId",
                        "Operator" : "Equal",
                        "Values" : [
                            "KB"
                        ]
                    }
                ]
            }
        }).then((response) => {
            //assertions
            assert.equal(response.body.Messages[0]["Id"], "rssoft.bfw.common.AccessDeniedError")
            //Access denied - To access this resource, you need the following right: API-RW-FI-AREASERVICE / *!
            assert.equal(response.body.Messages[0]["Text"], "Access denied - To access this resource, you need the following right: API-RW-FI-AREASERVICE / *!")

            expect(response.status).to.eq(200)


            
            
        })
    });

    //This testcase is to verify the user is not able to get Area using filter with an invalid context
    it("Verify the user is not able to get Area using filter with an invalid context", () => {


        
        cy.request({
            method: "Post",
            url: `${AreaBaseURL}AreaService.svc/json/Area/AreasByFilterContainer?context=123456789`,
           
            body: {
                
                
                "Filter" : [
                    {
                        "FieldName" : "AreaId",
                        "Operator" : "LessOrEqual",
                        "Values" : [
                            "3"
                        ]
                    },
                    {
                        "FieldName" : "StockAccountControlId",
                        "Operator" : "Equal",
                        "Values" : [
                            "KB"
                        ]
                    }
                ]
            }
        }).then((response) => {
              //assertions
              assert.equal(response.body.Messages[0]["Id"], "rssoft.common.rs2.authentication.InvalidContextValueError")
              //"The specified login context (123456789) is invalid"
              assert.equal(response.body.Messages[0]["Text"], "Der angegebene Anmelde-Context (123456789) ist ungültig")
  
              expect(response.status).to.eq(200)

        })
    });



})










