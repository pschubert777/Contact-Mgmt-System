using System;
using CMS.Data;
using CMS.DB;
using CMS.FormModels;
using Microsoft.AspNetCore.Components;

namespace CMS.Pages
{
	public class AddContactBase: ComponentBase
	{
        protected ContactModel newContactForm = new ContactModel();


        [Inject]
        NavigationManager NavigationManager { get; set; }

        [Inject]
        ContactService ContactService { get; set; }

        protected void cancelHandler()
        {
            NavigationManager.NavigateTo("");
        }
        protected async void submitHandler()
        {
            Contact newContact = new Contact();
            newContact.LastName = newContactForm.LastName;
            newContact.FirstName = newContactForm.FirstName;
            newContact.PhoneNumber = newContactForm.PhoneNumber;
            newContact.BirthDate = newContactForm.BirthDate;


            await ContactService.AddContact(newContact);

            NavigationManager.NavigateTo("");
        }
    }
}

