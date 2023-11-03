describe("Get Area List of Company", () => {

    var context = '';
    var BaseURL = 'localhost:8080//api-et-basis-v1-'
    var AreaBaseURL='localhost:8080//api-rw-fi-v1-'

it("prerequisites", () => {

        cy.login('rs', 'rsc', 'rs2', '100').then((res) => {
            context = res.body.Context;
        })
    })

    //This testcase is to verify the user can get all the value
it("Verify the user can get all the value", () => {


        
        cy.request({
            method: "GET",
            url: `${AreaBaseURL}AreaService.svc/json/Area/AreasByCompany?context=${context}`,
            
        }).then((response) => {

            //Assertions 
            assert.equal(response.body.Value[0]["AccountLength"], null)
            assert.equal(response.body.Value[0]["AccrualAreaAccountId"], null)
            assert.equal(response.body.Value[0]["AreaId"], 1)
            assert.equal(response.body.Value[0]["AutomaticReference"], 1)
            assert.equal(response.body.Value[0]["Billing"], null)
            assert.equal(response.body.Value[0]["CompanyId"], '100')
            assert.equal(response.body.Value[0]["Description"], 'Kostenstellen')
            assert.equal(response.body.Value[0]["HierarchicCompanyId"], '100')
            assert.equal(response.body.Value[0]["Position"], 1)
            assert.equal(response.body.Value[0]["ProfitAccountControlId"], 'KE')
            assert.equal(response.body.Value[0]["Reference"], null)
            assert.equal(response.body.Value[0]["SettlementArea1"], 0)
            assert.equal(response.body.Value[0]["SettlementArea2"], 0)
            assert.equal(response.body.Value[0]["SettlementArea3"], 0)
            assert.equal(response.body.Value[0]["SettlementArea4"], 0)
            assert.equal(response.body.Value[0]["SettlementArea5"], 0)
            assert.equal(response.body.Value[0]["SettlementArea6"], 0)
            assert.equal(response.body.Value[0]["StockAccountControlId"], "KB")
            assert.equal(response.body.Value[0]["UsingId"], "I")

            //Assertions 
            assert.equal(response.body.Value[1]["AccountLength"], null)
            assert.equal(response.body.Value[1]["AccrualAreaAccountId"], null)
            assert.equal(response.body.Value[1]["AreaId"], 2)
            assert.equal(response.body.Value[1]["AutomaticReference"], 0)
            assert.equal(response.body.Value[1]["Billing"], null)
            assert.equal(response.body.Value[1]["CompanyId"], '100')
            assert.equal(response.body.Value[1]["Description"], 'Kostenträger')
            assert.equal(response.body.Value[1]["HierarchicCompanyId"], '100')
            assert.equal(response.body.Value[1]["Position"], 2)
            assert.equal(response.body.Value[1]["ProfitAccountControlId"], 'KE')
            assert.equal(response.body.Value[1]["Reference"], null)
            assert.equal(response.body.Value[1]["SettlementArea1"], 0)
            assert.equal(response.body.Value[1]["SettlementArea2"], 0)
            assert.equal(response.body.Value[1]["SettlementArea3"], 0)
            assert.equal(response.body.Value[1]["SettlementArea4"], 0)
            assert.equal(response.body.Value[1]["SettlementArea5"], 0)
            assert.equal(response.body.Value[1]["SettlementArea6"], 0)
            assert.equal(response.body.Value[1]["StockAccountControlId"], "KB")
            assert.equal(response.body.Value[1]["UsingId"], null)

            //Assertions 
            assert.equal(response.body.Value[2]["AccountLength"], null)
            assert.equal(response.body.Value[2]["AccrualAreaAccountId"], null)
            assert.equal(response.body.Value[2]["AreaId"], 3)
            assert.equal(response.body.Value[2]["AutomaticReference"], 0)
            assert.equal(response.body.Value[2]["Billing"], null)
            assert.equal(response.body.Value[2]["CompanyId"], '100')
            assert.equal(response.body.Value[2]["Description"], 'Projekte')
            assert.equal(response.body.Value[2]["HierarchicCompanyId"], '100')
            assert.equal(response.body.Value[2]["Position"], 3)
            assert.equal(response.body.Value[2]["ProfitAccountControlId"], 'KE')
            assert.equal(response.body.Value[2]["Reference"], null)
            assert.equal(response.body.Value[2]["SettlementArea1"], 0)
            assert.equal(response.body.Value[2]["SettlementArea2"], 0)
            assert.equal(response.body.Value[2]["SettlementArea3"], 0)
            assert.equal(response.body.Value[2]["SettlementArea4"], 0)
            assert.equal(response.body.Value[2]["SettlementArea5"], 0)
            assert.equal(response.body.Value[2]["SettlementArea6"], 0)
            assert.equal(response.body.Value[2]["StockAccountControlId"], "KB")
            assert.equal(response.body.Value[2]["UsingId"], null)

            //Assertions 
            assert.equal(response.body.Value[3]["AccountLength"], null)
            assert.equal(response.body.Value[3]["AccrualAreaAccountId"], null)
            assert.equal(response.body.Value[3]["AreaId"], 4)
            assert.equal(response.body.Value[3]["AutomaticReference"], 0)
            assert.equal(response.body.Value[3]["Billing"], null)
            assert.equal(response.body.Value[3]["CompanyId"], '100')
            assert.equal(response.body.Value[3]["Description"], 'abc')
            assert.equal(response.body.Value[3]["HierarchicCompanyId"], '100')
            assert.equal(response.body.Value[3]["Position"], 3)
            assert.equal(response.body.Value[3]["ProfitAccountControlId"], null)
            assert.equal(response.body.Value[3]["Reference"], null)
            assert.equal(response.body.Value[3]["SettlementArea1"], 0)
            assert.equal(response.body.Value[3]["SettlementArea2"], 0)
            assert.equal(response.body.Value[3]["SettlementArea3"], 0)
            assert.equal(response.body.Value[3]["SettlementArea4"], 0)
            assert.equal(response.body.Value[3]["SettlementArea5"], 0)
            assert.equal(response.body.Value[3]["SettlementArea6"], 0)
            assert.equal(response.body.Value[3]["StockAccountControlId"], null)
            assert.equal(response.body.Value[3]["UsingId"], null)

            //Assertions 
            assert.equal(response.body.Value[4]["AccountLength"], null)
            assert.equal(response.body.Value[4]["AccrualAreaAccountId"], null)
            assert.equal(response.body.Value[4]["AreaId"], 5)
            assert.equal(response.body.Value[4]["AutomaticReference"], 0)
            assert.equal(response.body.Value[4]["Billing"], null)
            assert.equal(response.body.Value[4]["CompanyId"], '100')
            assert.equal(response.body.Value[4]["Description"], 'qwerty')
            assert.equal(response.body.Value[4]["HierarchicCompanyId"], '100')
            assert.equal(response.body.Value[4]["Position"], 3)
            assert.equal(response.body.Value[4]["ProfitAccountControlId"], null)
            assert.equal(response.body.Value[4]["Reference"], null)
            assert.equal(response.body.Value[4]["SettlementArea1"], 0)
            assert.equal(response.body.Value[4]["SettlementArea2"], 0)
            assert.equal(response.body.Value[4]["SettlementArea3"], 0)
            assert.equal(response.body.Value[4]["SettlementArea4"], 0)
            assert.equal(response.body.Value[4]["SettlementArea5"], 0)
            assert.equal(response.body.Value[4]["SettlementArea6"], 0)
            assert.equal(response.body.Value[4]["StockAccountControlId"], null)
            assert.equal(response.body.Value[4]["UsingId"], null)

            



        })
    });

 
})










