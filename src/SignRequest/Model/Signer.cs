/* 
 * SignRequest API
 *
 * API for SignRequest.com  # Getting Started  The SignRequest REST API enables you to send out signature requests. Using the API you will always have all the functionality as when using the frontend plus more.  When you're logged in and you have a Team enabled, you can also use the endpoints in your browser by visiting them.  It is also possible to receive events from SignRequest when, for example, a document has been signed. This way you can keep your application in sync with SignRequest without polling document endpoints. For this a callback url needs to be provided in the [team API settings page](/#/teams).  ## Sandbox Team  The easiest way to get started is by creating a free [Sandbox Team](/#teams?sandbox=true). Sandbox teams allow you to test out the entire SignRequest product without incurring charges. Everything works the same as a paid plan, except that all documents will be watermarked.  ## API Token  In order to use the API you first need to obtain an API token. You can create an API token in the [team API settings page](/#/teams).   Use tokens with a `Authorization: Token YOUR_TOKEN_HERE` header in your requests when making requests to the SignRequest API.  cURL example:  ```bash curl -H 'Authorization: Token YOUR_TOKEN_HERE' -H 'Content-Type:application/json' ```  ## Creating a Document  In order to send out a SignRequest we first need to create a document. There are three ways to create a document using the [documents endpoint](#operation/documents_create). One by sending a POST request that includes a `file`, two by providing `file_from_url` in which case SignRequest will download the document from that location, and three by providing base64 encoded document content in `file_from_content` together with the filename for this content in `file_from_content_name`. This can be useful if you have trouble POSTing the file together with other (nested, in the case of the [signrequest-quick-create endpoint](#operation/signrequest-quick-create_create)) configuration data. Please be sure to add the correct extension to the filename (e.g. my_pdf_file.pdf) in order for SignRequest to be able to determine the content type of the content.  Note that when using `file_from_url`, this url needs to be available for SignRequest to download. The download location may also be a Google Drive shareable link for documents (`application/vnd.google-apps.document`) and files (`application/vnd.google-apps.file`) uploaded to Google Drive. If the download location returns a content type of `text/plain` or `text/html`, SignRequest will do its best to make a PDF out of it. This can be used if you want to dynamically create PDF documents from web pages without making a PDF yourself. `external_id` is optional and can be used in order to have a reference to the document in your systems. The `name` field is also optional and can be customized, defaults to the filename (including extension).   ## Sending a SignRequest  Once you have successfully created a document, you can use the [signrequests endpoint](#operation/signrequests_create) to send a SignRequest using the `url` returned from the [documents endpoint](#operation/documents_create).  The minimal data needed to send out a SignRequest is the following:  ```json {     \"document\": \"https://signrequest.com/api/v1/documents/f2bac751-4fa1-43f1-91de-a1b8905c239a/\",      \"from_email\": \"you@yourcompany.com\",      \"message\": \"Please sign this document.\\n\\nThanks!\",      \"signers\": [         {             \"email\": \"tech-support@signrequest.com\"         }     ] } ```  Note that we always also create a signer for the `from_email` sending the SignRequest, however for this signer the `needs_to_sign` flag is set to `false` meaning that this signer will **not** get a SignRequest.  ## Quick Create a SignRequest  In some cases it might be desirable to create a document and send the SignRequest in one API call. This can be done using the [signrequest-quick-create endpoint](#tag/signrequest-quick-create). This endpoint takes all of the fields of the [documents](#operation/documents_create) and [signrequests](#operation/signrequests_create) endpoints together, creates the document, and sends the SignRequest.  ## Browsable API  In addition to our API docs, you can also explore our API endpoints using our [browsable API](/api/v1/). There you'll be able to browse our various endpoints and even perform requests against our live API.  # Working with a SignRequest  ## Add attachments to a SignRequest  Attachments can be added to a SignRequest using the [document-attachments endpoint](#operation/document-attachments_create). Signers will be able to download and read them before signing, but these will not be signed themselves. Document attachments can only be added when the SignRequest is not created yet.  ## Customizing the SignRequest email  If the Team has a custom color and logo these will be used in the SignRequest email. The `subject` and `message` fields can also be used to customize the email even further. The `message` may contain the following html tags: `a`, `abbr`, `acronym`, `b`, `blockquote`, `code`, `em`, `i`, `ul`, `li`, `ol`, and `strong`. Be aware that when the text to html ratio is too high, the email may end up in spam filters. Custom styles on these tags are not allowed.  When the `from_email_name` field is provided, this name will be used in the `From` email header as such `{from_email_name} <no-reply@signrequest.com>`. By default `Sender Name (sender@email.com) | SignRequest` is used as the `from_email_name`. Note that it's currently not possible to change the email address used to send a SignRequest.  ## Resend the SignRequest email(s)  The [resend_signrequest_email](#operation/signrequests_resend_signrequest_email) endpoint can be used to resend the SignRequest email as a reminder to all signers who didn't sign yet but did receive the email before.  ## Cancel a SignRequest  A SignRequest that has not been fully signed or declined yet can be cancelled using the [cancel_signrequest endpoint](#operation/signrequests_cancel_signrequest). By doing so all signers that have not signed yet will not be able to open and sign the document anymore.   ## Download a signed document  When a SignRequest has been signed the `pdf` field on the document resource will be filled with a link to download the signed PDF. The signing log PDF can be downloaded from the `pdf` field contained within the `signing_log` object field on the document resource.  The recommended way to download the files and store them in your own systems is to setup the [Events callback](#section/Events/Events-callback) functionality and have your application download the files on the `signed` (Document signed) event. Please note that the download links expire and are regenerated on every API call / events callback so download the files right away when needed.  ## Deleting documents  To delete a document for the owner of the document, send a DELETE request to the [document resource url](#operation/documents_delete). Note that at this point this only makes the document unavailable for the sender. For all signers that do not have a registered SignRequest account, a grace period is started to give them a chance to download the signed document. After this grace period the document will be deleted for these signers automatically. When all signers have requested a delete (manually, automatically, or via the API) or do not have a registered SignRequest account and the grace period has lapsed, the document will be fully deleted.  ### Automatic document deletion  To automatically delete a document the `auto_delete_days` field on a document can be set to a number of days after which a finished document (signed/cancelled/declined) will be automatically deleted. The behavior is the same as doing a DELETE on the document resource url X number of days after the document is finished. When the document is scheduled to be deleted the `auto_delete_after` will hold the date after which it will be deleted.  Note that we can make exceptions (to delete documents right away and entirely) for integration partners when they make the document available in other systems and users do not use SignRequest directly. Please [contact us](https://signrequest.com/en/contact/) to request an app screening if this functionality is required.  ## Chaining multiple documents  When sending a SignRequest, it's possible to reference a document in the `after_document` field on a `signer`. This should reference a document that the signer should be redirected to after signing. Since the signer is redirected to this document immediately after signing the other document, they do NOT get a SignRequest email. Note that resending the SignRequest email will trigger the SignRequest email even though they didn't receive one before.  When `after_document` references a document where the signer in question already has signed or declined they will still receive a SignRequest email as we cannot redirect them anymore. It's only possible to reference documents that are not fully signed (or declined) yet.  A `redirect_url` field is also available on a `signer` and on the `signrequest` (the default when not specified on the individual signers explicitly). When specified SignRequest will redirect to this url when a document is signed. Note that this only works when there are no chained documents for this signer anymore.  Chaining also works on the [signrequest-quick-create endpoint](#operation/signrequest-quick-create_create). When creating a SignRequest on that endpoint, you get a reference to the created document in the `document` field back which can be used in the next call to `signrequest-quick-create` when creating a chain with `after_document`.  ## Signer language  If known the language of the signer can be set in the `language` field. This will determine the language of the SignRequest email. The SignRequest browser interface language is by default set to the location, browser, or user account settings when available.  To force the language of the interface when a signer lands on the signing page the field `force_language` on the signer can be set to `true`. Note that if the language of the signer is not known it's best to not force the language.  Available languages:  `en` English   `en-gb` English (GB)   `nl` Dutch   `fr` French   `de` German   `he` Hebrew   `da` Danish   `fi` Finnish   `hu` Hungarian   `it` Italian   `no` Norwegian   `pl` Polish   `pt` Portuguese   `es` Spanish   `sv` Swedish   `ru` Russian   ## Text message and bank account verification  For a higher degree of authentication of your signers it is possible to enable text message phone number verification and bank account verification. These verifications can be enabled by providing the phone number to `verify_phone_number` (international format including the plus-sign) and/or the bank account to `verify_bank_account` on a signer. Currently it is only possible to verify bank accounts using [iDEAL](https://www.ideal.nl/en/).  When enabled, signers can only sign (finalize) a document when they have verified their phone number by a code supplied to them by a text message and/or make a payment of 1 cent. The verifications are logged and visible in the SignRequest signing log after completion.  Please note that we cannot force signers to make a payment using a specific bank account. Therefore the content of the field may also specify what type of account to use instead of a specific bank account number, e.g.: \"the bank account you want to use for paying the rent.\"  For this service additional fees apply. Please [contact us](https://signrequest.com/en/contact/) for a quote.  ## Disable signing tools/features  It is possible to disable certain tools/features signers have when signing a document. The following flags can be set to `true` on the signrequest model to disable these features.  - `disable_text`: disable adding of text - `disable_date`: disable adding of dates - `disable_attachments`: disable uploading/adding of attachments - `disable_text_signatures`: disable usage of signatures generated by typing (text) - `disable_upload_signatures`: disable usage of uploaded signatures (images)  Please note that we strongly **discourage you to disable features** as these are carefully chosen for optimal usability of the SignRequest product.  ## Required attachments  To require signers to upload attachments (like a passport for example) the `required_attachments` field can be used. The field takes an array of objects with one parameter `name`, for example: `required_attachments: [{\"name\": \"Passport\"}]`   ## Templates  In the frontend application it is possible to create templates. These templates, for Teams and Personal accounts, can be found in the [templates resource](#tag/templates). In order to send a SignRequest using a template, reference the resource url of the template in the `template` field. This works in both the [documents](#tag/documents) and the [signrequest-quick-create](#tag/signrequest-quick-create) resources.  ## Automatic reminders To enable automatic reminders set the `send_reminders` boolean to `true` on the [SignRequest resource](#tag/signrequests). When enabled SignRequest will automatically remind signers to sign a document.  # Preparing a document  Using the SignRequest frontend web application you have the option to \"prepare\" a document. This helps the receiver as they can only sign the document at the designated place.  Using the API you can also **prepare a document by using tags** to specify where a signer needs to add a date, text, checkbox, and/or a signature.  Tags need to start with `[[` and end with `]]`. The tag data is separated by a pipe `|`. The first letter of the tag represents the tag type and must be one of the following:  - `t` for text - `d` for date - `s` for signature - `c` for checkbox  The second piece of data is an integer representing the index of the signer for which this placeholder is intended. The numbers in the tags are used to make distinctions between the signers and group multiple tags (input fields) to one specific signer.  The template tags are assigned to the order at which the email addresses are added to the contact field and are not the same as the order of signing. This means that for example `s|1` can be the first or last signer depending on what you specified in the order of signing (if used of course).  As the sender is always the first email address added, this means the sender is always `s|0`. If the sender does not need to add a signature or other data input, then `s|0` will be assigned to the next in line.  Mismatches in the amount of declared placeholders and available signers will be silently ignored. The extra placeholders will not show up if more than the amount of signers **OR** signers just get an unprepared document to sign when there were no placeholders declared for them.  Examples:  ``` [[s|0                 ]]  // A signature for the first signer OR the owner/sender when they need to sign. [[c|0                 ]]  // A checkbox placeholder for the first signer [[d|1                 ]]  // A date input placeholder for the second signer [[t|2                 ]]  // A text input placeholder for the third signer ```  The height / width (font size) and the position of the tag in your document matters. Also as you do not want the **placeholder tag to show up in the document** to avoid this you need to make the font color match the background. Sign this demo document for an example (the color is left gray to see the tags):  ```html https://signrequest.com/#/?api=v1&who=m&from_email=you@yourcompany.com&doc_url=https%3A%2F%2Fsignrequest.com%2Fstatic%2Fdemo%2FSignRequestTagsExample.pdf ```  Note that the font chosen can make a difference in the bounding box margins and position. For most fonts the top margin will be bigger as desired. For this reason make sure to **leave enough space or double the line height** in order for the placeholder to not overlap the line above.  ## Tag modifiers There are multiple tag modifiers available to further customize the tags. The following key / value pairs can be used after the signer index.  - `r` to make a placeholder required to be filled: `1` / `true` for required `0` / `false` for not required - `m` to make a text placeholder multiline: `1` / `true` for multiline `0` / `false` for single line (default) - `n` to set a label/name on a text placeholder: 'a string' - `p` to prefill text/dates on a text/date placeholder: 'a string', for a date placeholder this can also be set to `0` / `false` to not prefill the current date. - `id` to assign an `external_id` to the placeholder: \"your_id\" (also see [Retrieving signer input](#section/Preparing-a-document/Retrieving-signer-input) and [Prefill tags](#section/Preparing-a-document/Prefill-tags-templates))  Examples:  ``` [[c|0|r:1                                ]]  // A checkbox that cannot be skipped (needs to be checked or not) [[c|0|r:0                                ]]  // A checkbox that can be skipped [[c|0|p:1                                ]]  // A checkbox that is by default checked (can be changed) [[d|0|n:Birth date|p:0                   ]]  // A date that is not prefilled with the date of signing and has the label 'Birth date' [[t|0|n:City|p:New York|id:customer_city ]]  // A text input placeholder with the label 'City', prefilled with the text 'New York' and an external_id of 'customer_city' that will be available later in the 'inputs' field (see: 'Retrieving signer input') and can be used to prefill the tag using prefill_tags on the document resource (see: 'Prefill tags'). ```  Note that placeholder names / prefilled data can get quite long. If this impacts the placeholder width/height you can choose to make the font between the opening `[[` and closing `]]` tags (really) small. The tag configuration does not need to be human readable as the text is extracted from the PDF format directly.  ## Prefill tags / templates  Instead of generating a new document and use the `p` tag modifier to prefill signer input data it is also possible to use `prefill_tags`. For this to work all tags need to have an `id` as this is needed to reference the tag.  Example:  ``` [[c|0|id:checkbox_1                      ]]  // Should be checked [[c|0|id:checkbox_2                      ]]  // Should not be checked [[d|0|n:Birth date|id:birth_date         ]]  // Should be prefilled with the birth date of the signer [[t|0|n:City|id:customer_city            ]]  // Should be prefilled with 'New York' ```  Now when a document contains the tags above you can prefill them using the `prefill_tags` field on document by referencing the 'id'.  ```json \"prefill_tags\": [     {\"external_id\":\"checkbox_1\", \"checkbox_value\":\"true\"},     {\"external_id\":\"checkbox_2\", \"checkbox_value\":\"false\"},     {\"external_id\":\"birth_date\", \"date_value\":\"1984-12-31\"},  // must be in ISO format ([YYYY]-[MM]-[DD])     {\"external_id\":\"customer_city\", \"text\":\"New York\"} ] ```  If you are using templates created from within the SignRequest app you can also set the `external_id` of a template tag in the advanced section when editing a tag.  Note that it's also possible to add these tags when using the <a href=\"#section/Frontend-API/SignRequest-js-client-(beta)\">SignRequest-js client</a> and the [Frontend API](#section/Frontend-API).  ## Prepare using the web interface  It is also possible to have the sender of a SignRequest prepare the document before sending the request out. To use this functionality, set the `is_being_prepared` flag on the SignRequest resource to `true`. When doing so the SignRequest will not be sent out to the recipient(s) and the `prepare_url` field will be set to a url where your application can redirect the sender to. Please note that if the sender does not have a SignRequest account they will be asked to verify their email after preparing the document. If you're an integration partner please [contact us](https://signrequest.com/en/contact/) for more possibilities when integrating this functionality.  Example:  ```json {     \"file_from_url\": \"https://signrequest.com/static/demo/SignRequestDemoDocument.pdf\",     \"from_email\": \"you@yourcompany.com\",     \"who\": \"mo\",     \"is_being_prepared\": \"true\",     \"signers\": [{\"email\": \"you@yourcompany.com\"}, {\"email\": \"tech-support@signrequest.com\"}] } ```  Note that it's perfectly fine to also include tags in the document. The sender will be able to change / remove them.  ## Retrieving signer input  All text, date, and boolean inputs of signers after a signer signs are available in the `inputs` field of a signer as text. This can be helpful if you need to update your systems based on data signers add to a document.  ```json \"inputs\": [     {         \"type\": \"d\",  // 's' (signature input), 't' (text input), 'd' (date input) or 'c' (checkbox input)         \"page_index\": 0,  // index of the page this input resides on         \"text\": \"09-25-18\",  // text as seen on the document (only for date and text inputs)         \"checkbox_value\": null,  // true or false (only for checkbox inputs)         \"date_value\": \"2018-09-25\",  // the date in ISO format ([YYYY]-[MM]-[DD])         \"external_id\": null  // optionally the external id assigned to a tag (helpful if you need to identify a specific input, also see 'Tag modifiers')     } ] ```  ## Tags Example  Signer 0: this is the first person that needs to sign (including you).  ![Signer 0](https://signrequest.com/assets/images/blogs/template-tags-electronic-signature-0.bf35c985.png)  Signer 1: this is the second person that needs to sign (including you).  ![Signer 1](https://signrequest.com/assets/images/blogs/template-tags-electronic-signature-1.335ad0c8.png)  The result in SignRequest:  ![Result in SignRequest](https://signrequest.com/assets/images/blogs/tags-example.2bb33d7f.png)  ## Example Documents  You can quickly test this feature with our example documents:  1. [Basic example document](https://docs.google.com/document/d/1oI2R1SxfMNZXiz3jCQvorpoklF9xq_dCJnOpkI-zo80/edit?usp=sharing) 2. [Advanced example document](https://docs.google.com/document/d/1-gzqym9clQ1a193JGocXUeIX92cqPINBHOBeGxbDASw/edit)  These are shared Google Docs documents with example tags. If you have our Google Docs Add-on you can directly send a SignRequest!  If you don't have our Google Docs Add-on for electronic signatures, go to \"Add-ons\" in the Google Docs menu bar and install the Add-on for free. Then, go back to \"Add-ons\" and click \"SignRequest\".  ## Walkthrough Video  We also have a walkthrough video on YouTube about using templates with tags in a base document:  [![Templates with tags in a base document](http://img.youtube.com/vi/y5U5WqTqZBQ/0.jpg)](http://www.youtube.com/watch?v=y5U5WqTqZBQ)  # Events  ## Events callback  In order to receive the `events` as a callback to your application a **callback url** needs to be set in the [team API settings](/#/teams) page. When set, SignRequest will POST events as `application/json` to this endpoint. Your endpoint should return a 200 OK response. SignRequest will retry delivering events in the case of a timeout or a 500 response from your server. It first waits one minute and then increases on every subsequent attempt according to a Fibonacci sequence for a maximum of ten attempts (1, 1, 2, 3, 5, etc).  It is also possible to change the **callback url on a per document basis**. To use this functionality you can set the callback url using the `events_callback_url` field when [creating a document](#operation/documents_create) or when using the [signrequest-quick-create endpoint](#tag/signrequest-quick-create).  Please be aware that we might add more event types in the future so code defensively for that.  For an example of how an event receiver can be written checkout this [repository](https://github.com/SignRequest/signrequest-event-receiver).  The following event types are available:  - `convert_error`: Document convert error   - `converted`: Document converted   - `sending_error`: Document sending error   - `sent`: Document sent   - `declined`: Document declined   - `cancelled`: Document cancelled   - `signed`: Document signed   - `signer_signed`: Signer signed   - `signer_email_bounced`: Signer email bounced   - `signer_viewed_email`: Signer viewed email   - `signer_viewed`: Signer viewed document   - `signer_forwarded`: Signer forwarded document   - `signer_downloaded`: Signer downloaded   - `signrequest_received`: SignRequest received    Status codes:  - `ok`: ok - `error`: error  The event status will be `error` for the following events: `convert_error`, `sending_error`, and `signer_email_bounced`.  The document status field can have the following codes:  - `co`: converting - `ne`: new - `se`: sent - `vi`: viewed - `si`: signed - `do`: downloaded - `sd`: signed and downloaded - `ca`: cancelled - `de`: declined - `ec`: error converting - `es`: error sending  Example callback request:  ```json {     \"document\": {         \"api_used\": true,          \"attachments\": [],          \"external_id\": \"your_id_of_this_document\",          \"file\": \"signrequest download url of the uploaded file\",          \"file_from_url\": \"url where signrequest downloaded the document, if this functionality was used\",          \"name\": \"document.pdf\",          \"pdf\": null,          \"prefill_tags\": [],          \"security_hash\": null,          \"signing_log\": null,          \"signrequest\": null,          \"status\": \"co\",          \"team\": {             \"name\": \"the_name_of_your_team\",              \"subdomain\": \"the_subdomain_of_your_team\"         },          \"template\": null,          \"url\": \"https://signrequest.com/api/v1/documents/f2bac751-4fa1-43f1-91de-a1b8905c239a/\",          \"user\": null,          \"uuid\": \"f2bac751-4fa1-43f1-91de-a1b8905c239a\"     },      \"event_hash\": \"89365cda10349ced9c3fd9c457372b37ad2e723c5b9f11a4d0b2c16724d8a2e7\",      \"event_time\": \"1537889008\",      \"event_type\": \"converted\",      \"signer\": null,      \"status\": \"ok\",      \"team\": {         \"name\": \"the_name_of_your_team\",          \"subdomain\": \"the_subdomain_of_your_team\"     },      \"timestamp\": \"2018-09-25T15:23:28.836457Z\",      \"token_name\": \"Token\",      \"uuid\": \"ffffd4dd-89c7-4133-ba2d-960f65c8d395\" } ```  If the event is **signer related** the `signer` field will contain all the signer data.  All event data can also be fetched using the REST API [Events resource](#tag/events). Be sure to check that out if you're developing your endpoint and see how the data looks.  You can check the authenticity (that the event really came from SignRequest) by generating and comparing the `event_hash` that comes with the event. The `event_hash` is generated with the HMAC algorithm using your API Token as a key in SHA256 digest mode.  OpenSSL shell example:  ```bash echo -n \"${event_time}${event_type}\" | openssl dgst -sha256 -hmac \"YOUR_TOKEN_HERE\" ```  which expands to:  ```bash echo -n \"1537889008converted\" | openssl dgst -sha256 -hmac \"YOUR_TOKEN_HERE\" 89365cda10349ced9c3fd9c457372b37ad2e723c5b9f11a4d0b2c16724d8a2e7 ```  If you have multiple API tokens created you can identify the used token by the `token_name` (if you provided one).  Always use **SSL enabled endpoints**!  Developing your callback endpoint locally? Checkout [UltraHook](http://www.ultrahook.com/) to receive webhooks on localhost, nifty!  ## Event webhooks  To receive only specific event callbacks, webhook subscriptions can be created for Teams and for Personal accounts. The resource takes an `event_type`, `callback_url` and optionally a `name` to easily identify what webhook is used for. The `integration` field can also be set when this hook is specific to one of the SignRequest supported integrations. Check out the [webhooks resource](#tag/webhooks) for all possible event types to subscribe to. When the webhooks are used on personal accounts these webhooks also receive the `signrequest_received` event which can be used to notify users that they have received a new SignRequest. However, creating webhook subscriptions for personal accounts requires a SignRequest session (logged in user) or Basic auth using a username and password.  ## Disable all SignRequest email events  It is possible to disable all SignRequest status emails as well as the email that contains the signed documents. When using this functionality the following events will not generate a SignRequest email:  - `sent`: Document sent - `signer_email_bounced`: Signer email bounced - `signer_viewed_email`: Signer viewed email - `signer_viewed`: Signer viewed document - `signer_signed`: Signer signed - `signed`: Document signed - `declined`: Document declined - `cancelled`: Document cancelled  To enable this feature set the `disable_emails` flag on the [SignRequest resource](#tag/signrequests) to true.   Note that the event emails will only be disabled if there is `callback_url` available for the document as your application is expected to notify users instead of SignRequest. The initial SignRequest email (that contains the link to sign) can only be disabled by using the [Embed url](#section/Additional-signing-methods/Embed-url) functionality.  # Frontend API  Another option to help your users sending SignRequests is using the \"frontend\" api. This involves no token and is merely used to \"prefill\" the SignRequest box found at the homepage for your users. The only requirement is that the document to send out is publicly available in order for SignRequest to download the file. Shareable links of Google Drive documents are also supported here.  GET params for prefilling the box:  ``` api=v1  // the version of the API to use who=mo  // mo='me & others', m='only me', o='only others' signers=first_email@example.com,second_email@example.com  // emails of 'signers' comma separated from_email=you@yourcompany.com  // email of the person sending the SignRequest doc_url=https%3A%2F%2Fsignrequest.com%2Fstatic%2Fdemo%2FSignRequestDemoDocument.pdf  // the url where SignRequest can download the document (quoted) ```  Example resulting url:  ``` https://signrequest.com/#/?api=v1&who=mo&signers=tech-support@signrequest.com&from_email=you@yourcompany.com&doc_url=https%3A%2F%2Fsignrequest.com%2Fstatic%2Fdemo%2FSignRequestDemoDocument.pdf ```  Note that you can also use prefill tags here by adding the parameter prefill_tags. The value should be Base64 encoded JSON, JavaScript example:  ```javascript btoa(JSON.stringify([{external_id: 'customer_city', text: 'New York'}])); // the output can be used with the parameter: // prefill_tags=W3siZXh0ZXJuYWxfaWQiOiJjdXN0b21lcl9jaXR5IiwidGV4dCI6Ik5ldyBZb3JrIn1d ```  ## SignRequest-js client (beta)  Although we consider the library \"beta\" you can count on a stable API (semver). However, if you plan to use this please [contact us](https://signrequest.com/en/contact/) so we know your use case and can help you out where needed. We will open up the repository to the public when out of beta.  To use the SignRequest javascript library include the following in your page (npm and bower are coming when out of beta):  ```html <script src=\"https://cdn.signrequest.com/signrequest-js/v1/signrequest-js.min.js\"></script> ``` Or for async loading use:  ```html <script> !function(t,e,n,i){var s=function(e,n){t.SignRequest&&t.SignRequest.loaded||setTimeout(function(){t.SignRequest.init(e,n)},50)};t.SignRequest=t.SignRequest||{loaded:0,init:s};var o=\"https:\"==e.location.protocol?\"https://\":\"http://\",u=e.createElement(\"script\");u.async=!0;var c=e.scripts[0];u.src=o+\"cdn.signrequest.com/signrequest-js/v1/signrequest-js.min.js\",c.parentNode.insertBefore(u,c),t.SignRequest.init(n,i)}(window,document,{   // this initial configuration is optional, may also be undefined   subdomain: ''  // you could for example initialize the library to use a specific team subdomain here }, function (SignRequest) {   // this callback is optional, may also be undefined   // SignRequest library is loaded and also passed as first argument   // execute your code... }); </script> ```  The library uses [UMD](https://github.com/umdjs/umd) (Universal Module Definition).  To use a specific version (current is **1.0.5**) use for example: **cdn.signrequest.com/signrequest-js/v1/1.0.5/signrequest-js.min.js**.  ### Usage  ```javascript // same as the frontend API GET parameters, these are all optional var conf = {     subdomain: '', // if you are using this for a specific team set the subdomain here     api: 'v1',     who: 'mo',     signers: 'first_email@example.com,second_email@example.com',     from_email: 'you@yourcompany.com',     close: true,  // close the popup when done? default: true     // or use next:     next: '',  // redirect to this url when done signing themselves,     frontend_id: '' // optional shared secret set on document to grant access to users even if they don't have access to team } // these are also optional, the popup will be centered in the window opening the popup var popup_conf = {     width: 460,  // width of the popup in pixels, default 460     height: 600, // height of the popup in pixels, default the height of the window opening the popup }  // to open a specific document first create a document using the REST API with your backend // be sure to also set the correct 'subdomain' in the configuration when you create a document for a specific team var doc_uuid = 'the-uuid-of-the-document'; SignRequest.browser.openPopupForDocUuid(doc_uuid, conf, popup_conf);  // to create a document from a url var doc_url = 'https://signrequest.com/static/demo/SignRequestDemoDocument.pdf' SignRequest.browser.openPopupForDocUrl(doc_url, conf, popup_conf);  // to create a document from a template uuid var template_uuid = 'the-uuid-of-the-template' SignRequest.browser.openPopupForTemplateUuid(template_uuid, conf, popup_conf);  // to open a popup using custom params var popup = SignRequest.browser.openPopup(conf, popup_conf);  // if your document contains template tags / placeholders that have an 'external_id' // it is possible to 'prefill' these for a particular SignRequest by updating your conf object with for example: conf.prefill_tags = [{external_id: 'customer_city', text: 'New York'}]; // Now all template tags with this external_id will be prefilled with 'New York'  // all popup openers return an instance of the popup to which event callbacks can be registered (they can be chained) // the possible events are: 'opened', 'sent', 'signed', 'declined', 'finished', 'closed', 'any' // note that 'sent', 'finished' and 'closed' can be called fast after each other when the popup autocloses (close: true) // also when sending a SignRequest and the sender also need to sign you can receive the 'signed' or 'declined' event // after the 'sent' event (SignRequest created). // When the sender is done (sending and possibly siging) the 'finished' event is fired. popup = popup.on('closed', function (event_type, payload, event) {     // this would fire when the popup closes, you might want to update your page based on events like this     console.log(event_type, payload, event); })  // shortcut to fire on all events ('any') popup.onAny(function (event_type, payload, event) {     // this would fire on all events     console.log(event_type, payload, event); })  // to set a default configuration to use in all future calls for example for a team subdomain SignRequest.browser.setConfig({subdomain: 'the_subdomain_of_your_team'});  // When creating a document for your users using our REST API and open that document in the popup in response to clicking a button // you might need to open the popup before you know the uuid of the document from your backend. // This to prevent popup blockers from kicking in when doing async work before we open a popup. // For this use case you can use the `openLoadingPopup` helper on click and use that already opened popup to load a document later.  $('button#your_button').on('click', function () {  // using jQuery in the following example (not required for signrequest-js)     var popup = SignRequest.browser.openLoadingPopup();  // open a popup on button click right away     popup.onAny(function (event_type, payload, event) {         // all listeners created on the loading popup will also be registered on the popup events fired later after the we call         // SignRequest.browser.openPopupForDocUuid...         console.log('Event received: ' + event_type + ', payload: ' + JSON.stringify(payload);     });     // Async call some endpoint on your backend that creates a document using the REST API.     $.post('/your-endpoint-to-create-a-document', {some: 'data'}).then(function(response){         // instead of opening a new popup we use the one that is 'loading' as otherwise         // most browser popup blockers will block opening a new window here (the opening of the window comes too late after the user click).         // we assume here your endpoint returns the uuid of the document created in the response         SignRequest.browser.openPopupForDocUuid(response.document_uuid, conf, {sr_popup: popup});         // `{sr_popup: popup}` make the library use an existing popup instead of creating a new one     }); });  SignRequest.browser.openPopupForDocUrl('https://signrequest.com/static/demo/SignRequestDemoDocument.pdf'); ```  ### Sharing document with external users  Normally a document stored within SignRequest would require the recipient to be a member of the document owner's team in order to gain access to the document. If you'd like to share a document outside of your team, you can [create a document](#operation/documents_create) while storing a shared secret on the `frontend_id` field. Then, using the SingRequest-js Client, you can add the `frontend_id` to the `conf` object when calling `openPopupForDocUuid` in order to grant any user presented with the signing popup access to the document.  # Additional signing methods  ## Embed url  Normally SignRequest will send the SignRequest email to signers containing the personal link to sign a document. This is how SignRequest validates an email address and is the preferred way. However, if your application requires a continuous flow (in a sales flow for example) it is possible to generate an `embed_url` and redirect a signer to that link. Combined with a `redirect_url` a continuous flow can be achieved.  Doing this moves the responsibility of identifying an email address / user to your application. This also shows in the signing log as SignRequest cannot guarantee that a document is signed by someone having access to an email address.  To generate the `embed_url` you need to declare the ID of the logged in user in YOUR application in the `embed_url_user_id` field. This ID will also show in the signing log.  The generated `embed_url` can only be used until the document is signed. Note that it is perfectly fine to combine signers with and without a generated `embed_url`. The `order` field also behaves as you would expect. For example, if the first signer (order = 0) has an `embed_url` generated and the second (order = 1) not, the second signer will only receive the SignRequest email when the first one has signed.  When using this `embed_url` in an `iframe`, you can add any of the following url parameters to hide some elements in the header: `&hide_login=1` (hide the login button), `&hide_cancel=1` (hide the cancel link), `&hide_decline=1` (hide the option to decline), `&hide_logo=1` (hide the logo) and `&hide_title=1` (hide the document title in the header). Be aware that the `embed_url` may already contain other url parameters. Also note that hiding the login button does not disable to login prompt for signers that already have a SignRequest account. This cannot be disabled.  If you also want to disable all other SignRequest emails, see [Disable all SignRequest email events](#section/Events/Disable-all-SignRequest-email-events).  ## In person signing  In some cases your application might want to generate one url for both the sender of the document and the receiver to sign a document after each other in person.  This can be achieved by this signer configuration example:  ```json {     \"file_from_url\": \"https://signrequest.com/static/demo/SignRequestDemoDocument.pdf\",     \"from_email\": \"you@yourcompany.com\",     \"who\": \"mo\",     \"signers\": [         {            \"email\": \"you@yourcompany.com\",            \"order\": 1,            \"embed_url_user_id\": \"your ID\",         },         {             \"email\": \"tech-support@signrequest.com\",             \"order\": 2,             \"in_person\": true         }     ] } ```  This way you can redirect the user to the `embed_url` of the sender. After the sender has signed they will be redirected to the next `in_person` signer.  # Integration Partners  ## Salesforce  The most straight forward way to integrate Salesforce with SignRequest is to use our managed package.  Normally you would use the SignRequest buttons provided in the managed package to create SignRequest documents from Salesforce but if you want to skip that step and create SignRequests using the API (but still sync documents to Salesforce) you can add the following data to a `signrequest`:  ```json \"integration_data\": {     \"object_type\": \"API NAME OF THE (S)OBJECT, e.g. 'Opportunity' or 'CustomObject__c'\",     \"uid\": \"UID OF THE SALESFORCE USER (NOT UUID), e.g. 'https:\\/\\/login.salesforce.com\\/id\\/00D24000000pMDZEA2\\/005240000048zB0AAI'\",     \"object_id\": \"OBJECT ID, e.g. 0062400000MaeNv\" }, \"integration\": \"salesforce\" ```  Caveat: The user of the `from_email` needs to be a member of the Team that created the `signrequest`, and the user needs to have a SignRequest account using Salesforce OAuth.  ## Zapier  Does your app integrate with Zapier? Chances are your digital signatures are just a few clicks away!  Checkout our Zapier integration here: https://signrequest.com/en/digital-electronic-signatures-with-zapier/  ## Becoming an integration partner  If your application requires to create Teams and act on behalf of them you need to become an integration partner. This only grants you access to resources created by your application of the third party Team.  Teams can be created and updated on the [Teams resource](#tag/teams).  Please [contact us](https://signrequest.com/en/contact/) to learn more.  ## OAuth2 Authorization Framework  SignRequest allows partner applications to use the API on behalf of SignRequest users using OAuth2. If you need this functionality you can [create an application here](/api/v1/oauth2/applications/) (choose Client type: Confidential, Authorization grant type: Authorization code) and [contact us](https://signrequest.com/en/contact/) if you need any help. The OAuth2 framework is [rfc-compliant](https://tools.ietf.org/html/rfc6749).  OAuth2 endpoints:  - https://signrequest.com/api/v1/oauth2/authorize/ Get authorization code   GET params: client_id, scope(s)[=we currently only support the 'read', 'write' scopes], response_type[=code], state[=your_random_state_string], redirect_uri[=if not provided the first of your application is used] - https://signrequest.com/api/v1/oauth2/token/ Request a new (refresh) token   POST params: code[=the client code], grant_type[=authorization_code], redirect_uri, client_id, client_secret[=required when using the 'confidential' client type] - https://signrequest.com/api/v1/oauth2/revoke_token/ Revoke a token   POST params: token[=token to revoke], token_type_hint[=optional, designating either 'access_token' or 'refresh_token'.  Use tokens with the `Authorization: Bearer YOUR_TOKEN_HERE` header in your requests. To remove your authorized applications/tokens during development [go here](/api/v1/oauth2/authorized_tokens/). [Contact us](https://signrequest.com/en/contact/) if you want your logo added to the consent screen.   # Client libraries  We have client libraries for the following languages. Is your language missing? Let us know!  - Python: https://github.com/SignRequest/signrequest-python-client   - Ruby: https://github.com/SignRequest/signrequest-ruby-client - Node.js (Javascript):  https://github.com/SignRequest/signrequest-node-client - C# (.NET): https://github.com/SignRequest/signrequest-csharp-client - PHP: https://github.com/SignRequest/signrequest-php-client - Event receiver (Python server): https://github.com/SignRequest/signrequest-event-receiver    ### More coming soon Documentation about more advanced usage of the SignRequest API and language specific client libraries is coming soon.  Feel free to contact us at tech-support@signrequest.com for any questions or feature requests. 
 *
 * OpenAPI spec version: v1
 * Contact: tech-support@signrequest.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = SignRequest.Client.SwaggerDateConverter;

namespace SignRequest.Model
{
    /// <summary>
    /// Signer
    /// </summary>
    [DataContract]
    public partial class Signer :  IEquatable<Signer>
    {
        /// <summary>
        /// Defines Language
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LanguageEnum
        {
            
            /// <summary>
            /// Enum En for value: en
            /// </summary>
            [EnumMember(Value = "en")]
            En = 1,
            
            /// <summary>
            /// Enum EnGb for value: en-gb
            /// </summary>
            [EnumMember(Value = "en-gb")]
            EnGb = 2,
            
            /// <summary>
            /// Enum Nl for value: nl
            /// </summary>
            [EnumMember(Value = "nl")]
            Nl = 3,
            
            /// <summary>
            /// Enum Fr for value: fr
            /// </summary>
            [EnumMember(Value = "fr")]
            Fr = 4,
            
            /// <summary>
            /// Enum De for value: de
            /// </summary>
            [EnumMember(Value = "de")]
            De = 5,
            
            /// <summary>
            /// Enum He for value: he
            /// </summary>
            [EnumMember(Value = "he")]
            He = 6,
            
            /// <summary>
            /// Enum Da for value: da
            /// </summary>
            [EnumMember(Value = "da")]
            Da = 7,
            
            /// <summary>
            /// Enum Fi for value: fi
            /// </summary>
            [EnumMember(Value = "fi")]
            Fi = 8,
            
            /// <summary>
            /// Enum Hu for value: hu
            /// </summary>
            [EnumMember(Value = "hu")]
            Hu = 9,
            
            /// <summary>
            /// Enum It for value: it
            /// </summary>
            [EnumMember(Value = "it")]
            It = 10,
            
            /// <summary>
            /// Enum No for value: no
            /// </summary>
            [EnumMember(Value = "no")]
            No = 11,
            
            /// <summary>
            /// Enum Pl for value: pl
            /// </summary>
            [EnumMember(Value = "pl")]
            Pl = 12,
            
            /// <summary>
            /// Enum Pt for value: pt
            /// </summary>
            [EnumMember(Value = "pt")]
            Pt = 13,
            
            /// <summary>
            /// Enum Es for value: es
            /// </summary>
            [EnumMember(Value = "es")]
            Es = 14,
            
            /// <summary>
            /// Enum Sv for value: sv
            /// </summary>
            [EnumMember(Value = "sv")]
            Sv = 15,
            
            /// <summary>
            /// Enum Ru for value: ru
            /// </summary>
            [EnumMember(Value = "ru")]
            Ru = 16
        }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public LanguageEnum? Language { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Signer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Signer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Signer" /> class.
        /// </summary>
        /// <param name="email">email (required).</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="needsToSign">needsToSign (default to true).</param>
        /// <param name="approveOnly">approveOnly.</param>
        /// <param name="notifyOnly">notifyOnly.</param>
        /// <param name="inPerson">inPerson.</param>
        /// <param name="order">order.</param>
        /// <param name="language">language.</param>
        /// <param name="forceLanguage">forceLanguage.</param>
        /// <param name="verifyPhoneNumber">verifyPhoneNumber.</param>
        /// <param name="verifyBankAccount">verifyBankAccount.</param>
        /// <param name="embedUrlUserId">embedUrlUserId.</param>
        /// <param name="useStampForApproveOnly">Place an approval stamp on a document when a signer approves a document.</param>
        /// <param name="redirectUrl">redirectUrl.</param>
        /// <param name="afterDocument">afterDocument.</param>
        /// <param name="integrations">integrations.</param>
        /// <param name="password">Require the signer to enter this password before signing a document. This field is write only..</param>
        public Signer(string email = default(string), string firstName = default(string), string lastName = default(string), bool? needsToSign = true, bool? approveOnly = default(bool?), bool? notifyOnly = default(bool?), bool? inPerson = default(bool?), int? order = default(int?), LanguageEnum? language = default(LanguageEnum?), bool? forceLanguage = default(bool?), string verifyPhoneNumber = default(string), string verifyBankAccount = default(string), string embedUrlUserId = default(string), bool? useStampForApproveOnly = default(bool?), string redirectUrl = default(string), string afterDocument = default(string), List<InlineDocumentSignerIntegrationData> integrations = default(List<InlineDocumentSignerIntegrationData>), string password = default(string))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for Signer and cannot be null");
            }
            else
            {
                this.Email = email;
            }
            this.FirstName = firstName;
            this.LastName = lastName;
            // use default value if no "needsToSign" provided
            if (needsToSign == null)
            {
                this.NeedsToSign = true;
            }
            else
            {
                this.NeedsToSign = needsToSign;
            }
            this.ApproveOnly = approveOnly;
            this.NotifyOnly = notifyOnly;
            this.InPerson = inPerson;
            this.Order = order;
            this.Language = language;
            this.ForceLanguage = forceLanguage;
            this.VerifyPhoneNumber = verifyPhoneNumber;
            this.VerifyBankAccount = verifyBankAccount;
            this.EmbedUrlUserId = embedUrlUserId;
            this.UseStampForApproveOnly = useStampForApproveOnly;
            this.RedirectUrl = redirectUrl;
            this.AfterDocument = afterDocument;
            this.Integrations = integrations;
            this.Password = password;
        }
        
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets EmailViewed
        /// </summary>
        [DataMember(Name="email_viewed", EmitDefaultValue=false)]
        public bool? EmailViewed { get; private set; }

        /// <summary>
        /// Gets or Sets Viewed
        /// </summary>
        [DataMember(Name="viewed", EmitDefaultValue=false)]
        public bool? Viewed { get; private set; }

        /// <summary>
        /// Gets or Sets Signed
        /// </summary>
        [DataMember(Name="signed", EmitDefaultValue=false)]
        public bool? Signed { get; private set; }

        /// <summary>
        /// Gets or Sets Downloaded
        /// </summary>
        [DataMember(Name="downloaded", EmitDefaultValue=false)]
        public bool? Downloaded { get; private set; }

        /// <summary>
        /// Gets or Sets SignedOn
        /// </summary>
        [DataMember(Name="signed_on", EmitDefaultValue=false)]
        public DateTime? SignedOn { get; private set; }

        /// <summary>
        /// Gets or Sets NeedsToSign
        /// </summary>
        [DataMember(Name="needs_to_sign", EmitDefaultValue=false)]
        public bool? NeedsToSign { get; set; }

        /// <summary>
        /// Gets or Sets ApproveOnly
        /// </summary>
        [DataMember(Name="approve_only", EmitDefaultValue=false)]
        public bool? ApproveOnly { get; set; }

        /// <summary>
        /// Gets or Sets NotifyOnly
        /// </summary>
        [DataMember(Name="notify_only", EmitDefaultValue=false)]
        public bool? NotifyOnly { get; set; }

        /// <summary>
        /// Gets or Sets InPerson
        /// </summary>
        [DataMember(Name="in_person", EmitDefaultValue=false)]
        public bool? InPerson { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }


        /// <summary>
        /// Gets or Sets ForceLanguage
        /// </summary>
        [DataMember(Name="force_language", EmitDefaultValue=false)]
        public bool? ForceLanguage { get; set; }

        /// <summary>
        /// Gets or Sets Emailed
        /// </summary>
        [DataMember(Name="emailed", EmitDefaultValue=false)]
        public bool? Emailed { get; private set; }

        /// <summary>
        /// Gets or Sets VerifyPhoneNumber
        /// </summary>
        [DataMember(Name="verify_phone_number", EmitDefaultValue=false)]
        public string VerifyPhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets VerifyBankAccount
        /// </summary>
        [DataMember(Name="verify_bank_account", EmitDefaultValue=false)]
        public string VerifyBankAccount { get; set; }

        /// <summary>
        /// Gets or Sets Declined
        /// </summary>
        [DataMember(Name="declined", EmitDefaultValue=false)]
        public bool? Declined { get; private set; }

        /// <summary>
        /// Gets or Sets DeclinedOn
        /// </summary>
        [DataMember(Name="declined_on", EmitDefaultValue=false)]
        public DateTime? DeclinedOn { get; private set; }

        /// <summary>
        /// Gets or Sets Forwarded
        /// </summary>
        [DataMember(Name="forwarded", EmitDefaultValue=false)]
        public string Forwarded { get; private set; }

        /// <summary>
        /// Gets or Sets ForwardedOn
        /// </summary>
        [DataMember(Name="forwarded_on", EmitDefaultValue=false)]
        public DateTime? ForwardedOn { get; private set; }

        /// <summary>
        /// Gets or Sets ForwardedToEmail
        /// </summary>
        [DataMember(Name="forwarded_to_email", EmitDefaultValue=false)]
        public string ForwardedToEmail { get; private set; }

        /// <summary>
        /// Gets or Sets ForwardedReason
        /// </summary>
        [DataMember(Name="forwarded_reason", EmitDefaultValue=false)]
        public string ForwardedReason { get; private set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; private set; }

        /// <summary>
        /// Gets or Sets EmbedUrlUserId
        /// </summary>
        [DataMember(Name="embed_url_user_id", EmitDefaultValue=false)]
        public string EmbedUrlUserId { get; set; }

        /// <summary>
        /// Gets or Sets Inputs
        /// </summary>
        [DataMember(Name="inputs", EmitDefaultValue=false)]
        public List<SignerInputs> Inputs { get; private set; }

        /// <summary>
        /// Place an approval stamp on a document when a signer approves a document
        /// </summary>
        /// <value>Place an approval stamp on a document when a signer approves a document</value>
        [DataMember(Name="use_stamp_for_approve_only", EmitDefaultValue=false)]
        public bool? UseStampForApproveOnly { get; set; }

        /// <summary>
        /// Gets or Sets EmbedUrl
        /// </summary>
        [DataMember(Name="embed_url", EmitDefaultValue=false)]
        public string EmbedUrl { get; private set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<SignerAttachment> Attachments { get; private set; }

        /// <summary>
        /// Gets or Sets RedirectUrl
        /// </summary>
        [DataMember(Name="redirect_url", EmitDefaultValue=false)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Gets or Sets AfterDocument
        /// </summary>
        [DataMember(Name="after_document", EmitDefaultValue=false)]
        public string AfterDocument { get; set; }

        /// <summary>
        /// Gets or Sets Integrations
        /// </summary>
        [DataMember(Name="integrations", EmitDefaultValue=false)]
        public List<InlineDocumentSignerIntegrationData> Integrations { get; set; }

        /// <summary>
        /// Require the signer to enter this password before signing a document. This field is write only.
        /// </summary>
        /// <value>Require the signer to enter this password before signing a document. This field is write only.</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Signer {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  EmailViewed: ").Append(EmailViewed).Append("\n");
            sb.Append("  Viewed: ").Append(Viewed).Append("\n");
            sb.Append("  Signed: ").Append(Signed).Append("\n");
            sb.Append("  Downloaded: ").Append(Downloaded).Append("\n");
            sb.Append("  SignedOn: ").Append(SignedOn).Append("\n");
            sb.Append("  NeedsToSign: ").Append(NeedsToSign).Append("\n");
            sb.Append("  ApproveOnly: ").Append(ApproveOnly).Append("\n");
            sb.Append("  NotifyOnly: ").Append(NotifyOnly).Append("\n");
            sb.Append("  InPerson: ").Append(InPerson).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  ForceLanguage: ").Append(ForceLanguage).Append("\n");
            sb.Append("  Emailed: ").Append(Emailed).Append("\n");
            sb.Append("  VerifyPhoneNumber: ").Append(VerifyPhoneNumber).Append("\n");
            sb.Append("  VerifyBankAccount: ").Append(VerifyBankAccount).Append("\n");
            sb.Append("  Declined: ").Append(Declined).Append("\n");
            sb.Append("  DeclinedOn: ").Append(DeclinedOn).Append("\n");
            sb.Append("  Forwarded: ").Append(Forwarded).Append("\n");
            sb.Append("  ForwardedOn: ").Append(ForwardedOn).Append("\n");
            sb.Append("  ForwardedToEmail: ").Append(ForwardedToEmail).Append("\n");
            sb.Append("  ForwardedReason: ").Append(ForwardedReason).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  EmbedUrlUserId: ").Append(EmbedUrlUserId).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  UseStampForApproveOnly: ").Append(UseStampForApproveOnly).Append("\n");
            sb.Append("  EmbedUrl: ").Append(EmbedUrl).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("  AfterDocument: ").Append(AfterDocument).Append("\n");
            sb.Append("  Integrations: ").Append(Integrations).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Signer);
        }

        /// <summary>
        /// Returns true if Signer instances are equal
        /// </summary>
        /// <param name="input">Instance of Signer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Signer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.EmailViewed == input.EmailViewed ||
                    (this.EmailViewed != null &&
                    this.EmailViewed.Equals(input.EmailViewed))
                ) && 
                (
                    this.Viewed == input.Viewed ||
                    (this.Viewed != null &&
                    this.Viewed.Equals(input.Viewed))
                ) && 
                (
                    this.Signed == input.Signed ||
                    (this.Signed != null &&
                    this.Signed.Equals(input.Signed))
                ) && 
                (
                    this.Downloaded == input.Downloaded ||
                    (this.Downloaded != null &&
                    this.Downloaded.Equals(input.Downloaded))
                ) && 
                (
                    this.SignedOn == input.SignedOn ||
                    (this.SignedOn != null &&
                    this.SignedOn.Equals(input.SignedOn))
                ) && 
                (
                    this.NeedsToSign == input.NeedsToSign ||
                    (this.NeedsToSign != null &&
                    this.NeedsToSign.Equals(input.NeedsToSign))
                ) && 
                (
                    this.ApproveOnly == input.ApproveOnly ||
                    (this.ApproveOnly != null &&
                    this.ApproveOnly.Equals(input.ApproveOnly))
                ) && 
                (
                    this.NotifyOnly == input.NotifyOnly ||
                    (this.NotifyOnly != null &&
                    this.NotifyOnly.Equals(input.NotifyOnly))
                ) && 
                (
                    this.InPerson == input.InPerson ||
                    (this.InPerson != null &&
                    this.InPerson.Equals(input.InPerson))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.ForceLanguage == input.ForceLanguage ||
                    (this.ForceLanguage != null &&
                    this.ForceLanguage.Equals(input.ForceLanguage))
                ) && 
                (
                    this.Emailed == input.Emailed ||
                    (this.Emailed != null &&
                    this.Emailed.Equals(input.Emailed))
                ) && 
                (
                    this.VerifyPhoneNumber == input.VerifyPhoneNumber ||
                    (this.VerifyPhoneNumber != null &&
                    this.VerifyPhoneNumber.Equals(input.VerifyPhoneNumber))
                ) && 
                (
                    this.VerifyBankAccount == input.VerifyBankAccount ||
                    (this.VerifyBankAccount != null &&
                    this.VerifyBankAccount.Equals(input.VerifyBankAccount))
                ) && 
                (
                    this.Declined == input.Declined ||
                    (this.Declined != null &&
                    this.Declined.Equals(input.Declined))
                ) && 
                (
                    this.DeclinedOn == input.DeclinedOn ||
                    (this.DeclinedOn != null &&
                    this.DeclinedOn.Equals(input.DeclinedOn))
                ) && 
                (
                    this.Forwarded == input.Forwarded ||
                    (this.Forwarded != null &&
                    this.Forwarded.Equals(input.Forwarded))
                ) && 
                (
                    this.ForwardedOn == input.ForwardedOn ||
                    (this.ForwardedOn != null &&
                    this.ForwardedOn.Equals(input.ForwardedOn))
                ) && 
                (
                    this.ForwardedToEmail == input.ForwardedToEmail ||
                    (this.ForwardedToEmail != null &&
                    this.ForwardedToEmail.Equals(input.ForwardedToEmail))
                ) && 
                (
                    this.ForwardedReason == input.ForwardedReason ||
                    (this.ForwardedReason != null &&
                    this.ForwardedReason.Equals(input.ForwardedReason))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.EmbedUrlUserId == input.EmbedUrlUserId ||
                    (this.EmbedUrlUserId != null &&
                    this.EmbedUrlUserId.Equals(input.EmbedUrlUserId))
                ) && 
                (
                    this.Inputs == input.Inputs ||
                    this.Inputs != null &&
                    this.Inputs.SequenceEqual(input.Inputs)
                ) && 
                (
                    this.UseStampForApproveOnly == input.UseStampForApproveOnly ||
                    (this.UseStampForApproveOnly != null &&
                    this.UseStampForApproveOnly.Equals(input.UseStampForApproveOnly))
                ) && 
                (
                    this.EmbedUrl == input.EmbedUrl ||
                    (this.EmbedUrl != null &&
                    this.EmbedUrl.Equals(input.EmbedUrl))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.RedirectUrl == input.RedirectUrl ||
                    (this.RedirectUrl != null &&
                    this.RedirectUrl.Equals(input.RedirectUrl))
                ) && 
                (
                    this.AfterDocument == input.AfterDocument ||
                    (this.AfterDocument != null &&
                    this.AfterDocument.Equals(input.AfterDocument))
                ) && 
                (
                    this.Integrations == input.Integrations ||
                    this.Integrations != null &&
                    this.Integrations.SequenceEqual(input.Integrations)
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.EmailViewed != null)
                    hashCode = hashCode * 59 + this.EmailViewed.GetHashCode();
                if (this.Viewed != null)
                    hashCode = hashCode * 59 + this.Viewed.GetHashCode();
                if (this.Signed != null)
                    hashCode = hashCode * 59 + this.Signed.GetHashCode();
                if (this.Downloaded != null)
                    hashCode = hashCode * 59 + this.Downloaded.GetHashCode();
                if (this.SignedOn != null)
                    hashCode = hashCode * 59 + this.SignedOn.GetHashCode();
                if (this.NeedsToSign != null)
                    hashCode = hashCode * 59 + this.NeedsToSign.GetHashCode();
                if (this.ApproveOnly != null)
                    hashCode = hashCode * 59 + this.ApproveOnly.GetHashCode();
                if (this.NotifyOnly != null)
                    hashCode = hashCode * 59 + this.NotifyOnly.GetHashCode();
                if (this.InPerson != null)
                    hashCode = hashCode * 59 + this.InPerson.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.ForceLanguage != null)
                    hashCode = hashCode * 59 + this.ForceLanguage.GetHashCode();
                if (this.Emailed != null)
                    hashCode = hashCode * 59 + this.Emailed.GetHashCode();
                if (this.VerifyPhoneNumber != null)
                    hashCode = hashCode * 59 + this.VerifyPhoneNumber.GetHashCode();
                if (this.VerifyBankAccount != null)
                    hashCode = hashCode * 59 + this.VerifyBankAccount.GetHashCode();
                if (this.Declined != null)
                    hashCode = hashCode * 59 + this.Declined.GetHashCode();
                if (this.DeclinedOn != null)
                    hashCode = hashCode * 59 + this.DeclinedOn.GetHashCode();
                if (this.Forwarded != null)
                    hashCode = hashCode * 59 + this.Forwarded.GetHashCode();
                if (this.ForwardedOn != null)
                    hashCode = hashCode * 59 + this.ForwardedOn.GetHashCode();
                if (this.ForwardedToEmail != null)
                    hashCode = hashCode * 59 + this.ForwardedToEmail.GetHashCode();
                if (this.ForwardedReason != null)
                    hashCode = hashCode * 59 + this.ForwardedReason.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.EmbedUrlUserId != null)
                    hashCode = hashCode * 59 + this.EmbedUrlUserId.GetHashCode();
                if (this.Inputs != null)
                    hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.UseStampForApproveOnly != null)
                    hashCode = hashCode * 59 + this.UseStampForApproveOnly.GetHashCode();
                if (this.EmbedUrl != null)
                    hashCode = hashCode * 59 + this.EmbedUrl.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.RedirectUrl != null)
                    hashCode = hashCode * 59 + this.RedirectUrl.GetHashCode();
                if (this.AfterDocument != null)
                    hashCode = hashCode * 59 + this.AfterDocument.GetHashCode();
                if (this.Integrations != null)
                    hashCode = hashCode * 59 + this.Integrations.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                return hashCode;
            }
        }
    }

}
