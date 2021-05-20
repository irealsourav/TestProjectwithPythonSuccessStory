Feature: Python
	Verify success story on Python page 

@PythonSuccessStory
Scenario Outline: Verify Success message
	Given The url of python webpage '<url>'
	And Go to successstories and arts
	And go to Submit yours
	When All data entered as '<story_name>' ,'<company_name>', '<company_url>','<category>','<author>','<author_email>','<pull quote>','<Content>'
	Then one message should show up '<success_message>'
	Examples: 

	| url                    | story_name | company_name | company_url             | category | author | author_email | pull quote       | Content     | success_message                                                                                      |
	| https://www.python.org | My Story   | Addecco      | https://www.adecco.com/ | Arts     | SG     | abc@xyz.de   | Nothing to worry | New content | Your success story submission has been recorded. It will be reviewed by the PSF staff and published. |



