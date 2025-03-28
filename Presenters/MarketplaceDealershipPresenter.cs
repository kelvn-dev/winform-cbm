using CBM.Customs;
using CBM.Models;
using CBM.Services;
using CBM.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CBM.Presenters {
  public class MarketplaceDealershipPresenter {

    private MarketplaceDealershipForm view;
    private List<KeyValuePair<Guid, string>> subscriptionPlanComboBoxData;

    public MarketplaceDealershipPresenter(MarketplaceDealershipForm view) {
      this.view = view;

      LoadComboBoxData();
      LoadSelectedData();
      this.view.RegisterEvent += Save;
      this.view.RegisterEvent += RefreshFields;
    }

    private void LoadComboBoxData() {
      subscriptionPlanComboBoxData = SubscriptionPlanService.GetComboBoxData("name");

      CBMComboBox subscriptionPlanComboBox = view.GetSubscriptionPlanComboBox();
      subscriptionPlanComboBox.DataSource = subscriptionPlanComboBoxData;
      subscriptionPlanComboBox.DisplayMember = "Value";
      subscriptionPlanComboBox.ValueMember = "Key";
    }

    private void Save(object sender, EventArgs e) {
      Dealership dealership = new Dealership {
        memberId = Guid.Parse(view.memberId.ToString()),
        subscriptionPlanId = Guid.Parse(view.subscriptionPlanId.ToString()),
        isRenewal = view.isRenewal,
        startDate = view.startDate,
        endDate = view.endDate,
        status = Enums.Status.PENDING.ToString()
      };
      Dealership check = DealershipService.GetByMemberId(view.memberId, false);
      try {
        //ModelValidation.Validate(dealership);
        if (check == null) {
          DealershipService.Create(dealership);
          view.message = "Registered successfully";
        }
        else {
          dealership.id = check.id;
          DealershipService.Update(dealership);
          view.message = "Updated successfully";
        }
        view.isSuccessful = true;
        LoadSelectedData();
      }
      catch (Exception ex) {
        view.isSuccessful = false;
        view.message = ex.Message;
      }
    }

    private void RefreshFields(object sender, EventArgs e) {
      LoadSelectedData();
    }

    private void LoadSelectedData() {
      Dealership dealership = DealershipService.GetByMemberId(view.memberId, false);
      if (dealership != null) {
        view.id = dealership.id;
        view.isRenewal = dealership.isRenewal;
        view.startDate = dealership.startDate;
        view.endDate = dealership.endDate;
        view.status = dealership.status.Trim();

        SubscriptionPlan subscriptionPlan = SubscriptionPlanService.GetById(dealership.subscriptionPlanId);
        KeyValuePair<Guid, string> selectedSubscriptionPlan = new KeyValuePair<Guid, string>(subscriptionPlan.id, subscriptionPlan.name);
        view.subscriptionPlanId = selectedSubscriptionPlan;
      }
    }
  }
}
